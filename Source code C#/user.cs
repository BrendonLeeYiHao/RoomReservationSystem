using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOPAssignment
{
    class user
    {
        //LOGIN FEATURE
        private string usertype;
        private string username;
        private string password;
        private string usertype1;
        private string email;
        private string phonenumber;
        private string position;

        public string Usertype { get => usertype; set => usertype = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Usertype1 { get => usertype1; set => usertype1 = value; }
        public string Email { get => email; set => email = value; }
        public string Phonenumber { get => phonenumber; set => phonenumber = value; }
        public string Position { get => position; set => position = value; }

        public user(string name, string pass, string user)
        {
            username = name;
            password = pass;
            usertype1 = user;
        }

        public user(string un, string pw, string em, string pn, string po)
        {
            username = un;
            password = pw;
            email = em;
            phonenumber = pn;
            position = po;
        }
        
        public user(string une,string psw, string ema, string phn)
        {
            username = une;
            password = psw;
            email = ema;
            phonenumber = phn;
        }

        public void Register()
        {
            int toggle = 0;  //declare int toggle and setting toggle to 0;
            bool approve = true;

            while (approve)  //while True
            {
                if (!Regex.Match(username, "^[a-zA-Z, ]{3,45}$").Success)  //if username entered is not alphabets or alphabets with spaces or username entered not in between (3-45)
                {
                    MessageBox.Show("Invalid username!!! Only Accept Alphabets and Spaces\n\nUsername length is between 3-45", "Warning", MessageBoxButtons.OK); //show error message
                    toggle = 1;  //toggle has the value 1
                    break;  //break from loop
                }


                else if (!Regex.Match(password, "^[A-Za-z0-9]{3,10}$").Success)  //if password entered does not have alphabets or numbers or having spaces in between or password entered not in a range from 3-10
                {
                    MessageBox.Show("Invalid Password!!! Only Accept Alphabets and Numbers!!! No Spacing in between\n\nPassword length is between 3-10", "Warning", MessageBoxButtons.OK);  //show error message
                    toggle = 1;  //toggle has the value 1
                    break;  //break from loop
                }

                else if (!Regex.Match(email, "^[A-Za-z0-9]{3,30}[@][g][m][a][i][l][.][c][o][m]+$").Success)  //if email entered is not according to the format example@gmail.com, whereby example can accept a range of 3-30 characters inclusive of upper case, lower case or numbers
                {
                    MessageBox.Show("Invalid Email!!! Format is example@gmail.com\n\n'example' length is between 3-30", "Warning", MessageBoxButtons.OK);  //show error message
                    toggle = 1;  //toggle has the value 1
                    break;  //break from loop
                }  

                else if (!Regex.Match(phonenumber, "^[0][1][0-9]-[0-9]{7,8}$").Success)  //if phone number entered does not start with 01 and followed by a digit and hyphen and 7 or 8 digits. (Ex. 01X-XXXXXXX or 01X-XXXXXXXX)
                {
                    MessageBox.Show("Invalid Phone Number!!! Format is 01X-XXXXXXX or 01X-XXXXXXXX", "Warning", MessageBoxButtons.OK);  //show error message
                    toggle = 1;  //toggle has the value 1
                    break;  //break from loop
                }

                else  //if all conditions above do not match
                    break;  //break from loop
                            //toggle has the value 0               
            }

            if (toggle == 0)
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
                con.Open();
                SqlCommand cmd2 = new SqlCommand("Insert into UserLogin(Username,Password,Usertype,Email,PhoneNumber) values (@un,@pw,@po,@em,@pn)", con);
                cmd2.Parameters.AddWithValue("@un", username);
                cmd2.Parameters.AddWithValue("@pw", password);
                cmd2.Parameters.AddWithValue("@po", position);
                cmd2.Parameters.AddWithValue("@em", email);
                cmd2.Parameters.AddWithValue("@pn", phonenumber);

                try
                {
                    int i = cmd2.ExecuteNonQuery();
                    MessageBox.Show("Registration Successful");
                }

                catch (SqlException) //Since Username in UserLogin table is set as primary key, it has to be unique
                {
                    MessageBox.Show("Username already Exists"); //show error message as username entered is the same as the one in database
                }

                con.Close();
            }
        }
        public void Login()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("select count(*) from UserLogin where Username = '" + username + 
                "'and Password = '" + password + "'", con);

            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            if (count > 0)
            {
                SqlCommand cmd2 = new SqlCommand("select UserType from UserLogin where Username = '" + username + "'and Password = '" + password + "'", con);

                string usertype = cmd2.ExecuteScalar().ToString();

                if ((usertype == usertype1) && (usertype == "Admin"))
                {
                    MessageBox.Show("Librarian");
                    LibrarianPage lib = new LibrarianPage(username);
                    lib.Show();
                    
                }
                else if ((usertype == usertype1) && (usertype == "Student"))
                {
                    MessageBox.Show("Student", "User type", MessageBoxButtons.OK);
                    StudentPage st = new StudentPage(username);
                    st.Show();
                   
                }
                else
                {
                    MessageBox.Show("Incorrect usertype");
                }
            }
            else
                MessageBox.Show("Incorrect username or password");
            con.Close();
        }


        public void Updateinfo()
        {
            int toggle = 0;  //declare int toggle and setting toggle to 0;
            bool approve = true;

            while (approve)  //while True
            {
                if (!Regex.Match(password, "^[A-Za-z0-9]{3,10}$").Success)  //if password entered does not have alphabets or numbers or having spaces in between or password entered not in a range from 3-10
                {
                    MessageBox.Show("Invalid Password!!! Only Accept Alphabets and Numbers!!! No Spacing in between\n\nPassword length is between 3-10", "Warning", MessageBoxButtons.OK);  //show error message
                    toggle = 1;  //toggle has the value 1
                    break;  //break from loop
                }

                else if (!Regex.Match(email, "^[A-Za-z0-9]{3,30}[@][g][m][a][i][l][.][c][o][m]+$").Success)  //if email entered is not according to the format example@gmail.com, whereby example can accept a range of 3-30 characters inclusive of upper case, lower case or numbers
                {
                    MessageBox.Show("Invalid Email!!! Format is example@gmail.com\n\n'example' length is between 3-30", "Warning", MessageBoxButtons.OK);  //show error message
                    toggle = 1;  //toggle has the value 1
                    break;  //break from loop
                }

                else if (!Regex.Match(phonenumber, "^[0][1][0-9]-[0-9]{7,8}$").Success)  //if phone number entered does not start with 01 and followed by a digit and hyphen and 7 or 8 digits. (Ex. 01X-XXXXXXX or 01X-XXXXXXXX)
                {
                    MessageBox.Show("Invalid Phone Number!!! Format is 01X-XXXXXXX or 01X-XXXXXXXX", "Warning", MessageBoxButtons.OK);  //show error message
                    toggle = 1;  //toggle has the value 1
                    break;  //break from loop
                }

                else  //if all conditions above do not match
                    break;  //break from loop
                            //toggle has the value 0               

            }

            if (toggle == 0)
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
                con.Open();
                SqlCommand cmd = new SqlCommand("Update UserLogin set Password = '" + password + "' , Email = '" + email + "', PhoneNumber = '" + phonenumber + "' where Username = '" + username + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Update Successful");  //show successful message
                con.Close();
            }
        }
     
    }
}
