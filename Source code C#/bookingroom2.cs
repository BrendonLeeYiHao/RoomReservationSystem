using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace IOOPAssignment
{
    class bookingroom2
    {
        private string roomtype;
        private string room;
        private string username;
        private string initialtime;
        private string finaltime;
        private string dates;
        private string requestpar;
        private string RoomID;
        private string roomonly;
        private string roomstatus;
        private static DateTime date;
        private static DateTime DateAndTime;



        public string Roomtype { get => roomtype; set => roomtype = value; }
        public string Room { get => room; set => room = value; }
        public string Username { get => username; set => username = value; }
        public string Initialtime { get => initialtime; set => initialtime = value; }
        public string Finaltime { get => finaltime; set => finaltime = value; }
        public string Dates { get => dates; set => dates = value; }
        public string Requestpar { get => requestpar; set => requestpar = value; }
        public string Roomonly { get => roomonly; set => roomonly = value; }
        public static DateTime DateAndTime1 { get => DateAndTime; set => DateAndTime = value; }
        public static DateTime Date { get => date; set => date = value; }
        public string RoomID1 { get => RoomID; set => RoomID = value; }
        public string Roomstatus { get => roomstatus; set => roomstatus = value; }

        public bookingroom2(string rt, string r, string un, string it, string ft, string d, string rpar, string rid)
        {
            roomtype = rt;
            room = r;
            username = un;
            initialtime = it;
            finaltime = ft;
            dates = d;
            requestpar = rpar;
            RoomID = rid;
        }


        public void Delete()
        {
            DialogResult dialogresult = MessageBox.Show
                ("Do you wish to delete?", "Delete", MessageBoxButtons.YesNo);//Show messagebox to ask for user's confirmation
            if (dialogresult == DialogResult.Yes)
            {

                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
                con.Open(); 
                SqlCommand cmd3 = new SqlCommand 
                ("delete from Booking where RoomID = '" + RoomID + "'", con); //delete booking from database
                int ind = cmd3.ExecuteNonQuery();
                if (ind != 0)
                {
                    MessageBox.Show("Delete successful"); //display successful message 
                }
                else
                {
                    MessageBox.Show("Delete Fail"); //display fail message 
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Booking not deleted"); //display booking not deleted 
            }
        }
        public void Modify()
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            if (roomstatus == "Pending" || roomstatus == "Declined") //if roomstatus is pending or declined
            {

                MessageBox.Show("Update Fail. Existing booking does not exist!"); //display update fail 
                con.Close();
            }

            else
            {

                int A = 0;
                SqlCommand cmd2 = new SqlCommand("Select * from Booking where RoomAvailable = 'Pending' ", con); //select data from table Booking where RoomAvailable is 'Pending'
                SqlDataReader rd = cmd2.ExecuteReader(); //execute the query
                while (rd.Read())
                {
                    string roomcheck = rd.GetString(2); //get value from the 'Room' column of the row
                    string checkdate = rd.GetString(3); //get value from the 'Date' column of the row
                    DateTime datecheck = DateTime.ParseExact(checkdate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    string checkinitialtime = rd.GetString(4); //get value from the 'InitialTime' column of the row
                    DateTime initialtimecheck = DateTime.Parse(checkinitialtime);
                    string checkfinaltime = rd.GetString(5); //get value from the 'FinalTime' column of the row
                    DateTime finaltimecheck = DateTime.Parse(checkfinaltime);
                    string namecheck = rd.GetString(7); //get value from the 'Username' column of the row

                    TimeSpan timedifference = DateTime.Parse(finaltime) - DateTime.Parse(initialtime); //find time difference
                    DateAndTime = DateTime.Now;
                    date = DateAndTime.Date;
                    TimeSpan datediff = DateTime.ParseExact(dates, "dd/MM/yyyy", CultureInfo.InvariantCulture) - date; //find date difference

                    if ((timedifference.TotalHours > 6) || (timedifference.TotalHours < 0.5)) //display error if time difference is more than 6 hours or less than 30 minutes
                    {
                        MessageBox.Show("Reservation duration is min 30 minutes and max 6 hours");
                        A = 1;
                        break;
                    }

                    if ((datediff.TotalDays > 32) || (datediff.TotalHours < 47)) //display error if booking is done less than 2 days or is more than 30 days ahead
                    {
                        MessageBox.Show("Booking period is within 30 days \nYou are only allowed to book two days prior to your booking");
                        A = 1;
                        break;
                    }

                    if ((DateTime.ParseExact(dates, "dd/MM/yyyy", CultureInfo.InvariantCulture) == datecheck) && (username == namecheck)) //if the booking date are the same, the username are the same
                    {
                        MessageBox.Show("Max 1 Booking per day, Please check your reservation record");
                        A = 1;
                        break;
                    }

                    if (DateTime.ParseExact(dates, "dd/MM/yyyy", CultureInfo.InvariantCulture) == datecheck) //if the new booking date = old booking date in the database 
                    {

                        if (roomonly == roomcheck) //the new booking room = same room booked
                        {       //validation for the room booked so that no room booked on the same time
                            if (((DateTime.Parse(initialtime) >= initialtimecheck) && (DateTime.Parse(initialtime) < finaltimecheck)) ||
                                ((DateTime.Parse(finaltime) > initialtimecheck) && (DateTime.Parse(finaltime) < finaltimecheck)) ||
                                ((DateTime.Parse(initialtime) <= initialtimecheck) && (DateTime.Parse(finaltime) > initialtimecheck)))
                            {
                                MessageBox.Show("Time slot is not available");
                                A += 1;
                                con.Close();
                                break;
                            }
                        }

                        else
                        {
                            continue;
                        }

                    }


                }
                if (A == 0)
                {
                    //update the room details with new data
                    SqlCommand cmd3 = new SqlCommand
                        ("update Booking set roomtype = @rt, room = @r, initialtime = @it, finaltime = @ft, date = @d, RoomAvailable = 'Pending' " +
                        "where RoomID  = '" + RoomID + "' ", con);
                    cmd3.Parameters.AddWithValue("@rt", Roomtype);
                    cmd3.Parameters.AddWithValue("@r", Room);
                    cmd3.Parameters.AddWithValue("@it", Initialtime);
                    cmd3.Parameters.AddWithValue("@ft", Finaltime);
                    cmd3.Parameters.AddWithValue("@d", Dates);
                    cmd3.Parameters.AddWithValue("@rpar", Requestpar);
                    int ind = cmd3.ExecuteNonQuery();
                    if (ind != 0)
                    {
                        MessageBox.Show("Update successful"); //show success when it is executed
                        con.Close();

                    }
                    else
                    {
                        MessageBox.Show("Update Fail"); //show fail if it is fail to execute
                        con.Close();
                    }
                }


                con.Close();
            }
        }
    }
}
