using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOPAssignment
{
    class bookingroom
    {
        private string roomtype;
        private string room;
        private string username;
        private string initialtime;
        private string finaltime;
        private string dates;
        private string requestpar;


        public string Roomtype { get => roomtype; set => roomtype = value; }
        public string Room { get => room; set => room = value; }
        public string Username { get => username; set => username = value; }
        public string Initialtime { get => initialtime; set => initialtime = value; }
        public string Finaltime { get => finaltime; set => finaltime = value; }
        public string Dates { get => dates; set => dates = value; }
        public string Requestpar { get => requestpar; set => requestpar = value; }

        public bookingroom(string rt, string r, string un, string it, string ft, string d, string rpar)
        {
            roomtype = rt;
            room = r;
            username = un;
            initialtime = it;
            finaltime = ft;
            dates = d;
            requestpar = rpar;
        }

        public void studentreservation()
        {
            int A = 0;  //declare A as int and setting A to 0.
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmd2 = new SqlCommand("Select * from Booking where RoomAvailable = 'Approved' ", con);  //Select All from Booking Table where RoomAvailable column = 'Approved'
            SqlDataReader rd = cmd2.ExecuteReader();
            while (rd.Read())  //Read row by row, starting from first row
            {           
                string roomcheck = rd.GetString(2);                             //roomcheck stores the string from the third column
                string checkdate = rd.GetString(3);                             //checkdate stores the string from the fourth column
                DateTime datecheck = DateTime.Parse(checkdate);                 //convert string checkdate to datetime datatype and store in datecheck
                string checkinitialtime = rd.GetString(4);                      //checkinitialtime stores the string from the fifth column
                DateTime initialtimecheck = DateTime.Parse(checkinitialtime);   //convert string checkinitialtime to datetime datatype and store in initialtimecheck
                string checkfinaltime = rd.GetString(5);                        //checkfinaltime stores the string from the sixth column
                DateTime finaltimecheck = DateTime.Parse(checkfinaltime);       //convert string checkfinaltime to datetime datatype and store in finaltimecheck
                string namecheck = rd.GetString(7);                             //namecheck stores the string from the eighth column

                TimeSpan timedifference = DateTime.Parse(finaltime) - DateTime.Parse(initialtime);  //converting string finaltime and string initialtime to datetime datatype, duration between finaltime - initialtime is stored in timedifference
                DateTime DateAndTime = DateTime.Now;                         //declare DateAndTime and stores the current date and time
                DateTime date = DateAndTime.Date;                           //removing time from DateAndTime and store in datetime date
                TimeSpan datediff = DateTime.Parse(dates) - date;           //convert string dates to datetime datatype, duration between dates - date is stored in datediff

                if ((timedifference.TotalHours > 6) || (timedifference.TotalHours < 0.5))  //if timedifference > 6 hours  or  timedifference < 0.5 hours
                {
                    MessageBox.Show("Reservation duration is min 30 minutes and max 6 hours");  //show error message
                    A = 1;  //A has the value 1
                    break;  //break from loop
                }

                if ((datediff.TotalDays > 32) || (datediff.TotalHours < 47))    //if datediff > 32 days  or datediff < 47 hours
                {
                    MessageBox.Show("Booking period is within 30 days \nYou are only allowed to book two days prior to your booking");  //show error message
                    A = 1;  //A has the value 1
                    break;  //break the loop
                }

                if ((DateTime.Parse(dates) == datecheck) && (username == namecheck))    //if  dates == datecheck  and username == namecheck
                {
                    MessageBox.Show("Max 1 Booking per day, Please check your reservation record"); //show erro message
                    A = 1;  //A has the value 1     
                    break;  //break from loop
                }

                    if ((room == roomcheck) && (DateTime.Parse(dates) == datecheck))    //if room == roomcheck and dates == datecheck
                {
                    if (((DateTime.Parse(initialtime) >= initialtimecheck) && (DateTime.Parse(initialtime) < finaltimecheck)) ||    //if initialtime is in between initialtimecheck and finaltimecheck
                        ((DateTime.Parse(finaltime) > initialtimecheck) && (DateTime.Parse(finaltime) < finaltimecheck)) ||       //if finaltime is in between initialtimecheck and finaltimecheck
                        ((DateTime.Parse(initialtime) <= initialtimecheck) && (DateTime.Parse(finaltime) > initialtimecheck)))    //(if initialtime smaller than or equal to initialtimecheck)   and   (finaltime greater than initialtimecheck)
                    {
                        MessageBox.Show("Time slot is not available");  //show error message
                        A = 1;  //A has the value 1
                        break;  //break from loop
                    }
          
                }

                else 
                {
                    continue;  //read next row
                }

            }

            if (A == 0)
            {
                DialogResult doubleconfirm = MessageBox.Show("Roomtype\t: " + roomtype + "\nRoom\t\t: " + room + "\nDate\t\t: " + dates + "\nInitial Time\t: " + initialtime + "\nFinal Time\t: " + finaltime + "","Your Booking Details",MessageBoxButtons.YesNo); //show booking details and prompt user to click yes or no for confirmation
                if (doubleconfirm == DialogResult.Yes)  //if select yes
                {
                    SqlCommand cmd = new SqlCommand("insert into Booking(username,roomtype,room,initialtime,finaltime,date,RoomAvailable) values(@un,@rt,@r,@it,@ft,@d,@rpar)", con);   //insert the selected items into distinguished column in Booking table

                    cmd.Parameters.AddWithValue("@un", username);
                    cmd.Parameters.AddWithValue("@rt", roomtype);
                    cmd.Parameters.AddWithValue("@r", room);
                    cmd.Parameters.AddWithValue("@it", initialtime);
                    cmd.Parameters.AddWithValue("@ft", finaltime);
                    cmd.Parameters.AddWithValue("@d", dates);
                    cmd.Parameters.AddWithValue("@rpar", requestpar);
                    int i = cmd.ExecuteNonQuery();
                    if (i != 0) //if i not 0
                    {
                        MessageBox.Show("Booking successful");  //show successful message
                    }
                    else  //if i is 0
                    {
                        MessageBox.Show("Booking Fail");    //show failed message
                    }
                }
                else  //if select no
                {
                    MessageBox.Show("Booking not Saved");   //show booking not saved message
                }

            }
            con.Close();
        }


    }
}
