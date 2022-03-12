using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOPAssignment
{
    public partial class UpdateStudentDetails : Form
    {
        public static string username;
        
        public UpdateStudentDetails(string un)
        {
            InitializeComponent();
            username = un;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();    //hide UpdateStudentDetails form
            StudentPage sp = new StudentPage(username);     
            sp.Show();  //show StudentPage form

        }

        private void UpdateStudentDetails_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Username, Password, Email, PhoneNumber from UserLogin where Username = '" + username + "'", con);   //Select Username, Password, Email and Phone Number from UserLogin table whereby Username == username passed
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())   //read each row, starting from first
            {
                lblusername.Text = rd.GetString(0);     //lblusername.Text stores string from Username column
                txtpassword.Text = rd.GetString(1);     //txtpassword.Text stores string from Password column
                txtemail.Text = rd.GetString(2);        //txtemail.Text stores string from Email column
                txtphone.Text = rd.GetString(3);        //txtphone.Text stores string from PhoneNumber column
            }
            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            user up = new user(lblusername.Text, txtpassword.Text, txtemail.Text, txtphone.Text); //declare up as object of class user with 5 string arguments in user constructor
            up.Updateinfo();  //execute member method UpdateInfo()
        }
    }
}
