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
    class librarian
    {
        private static string roomid;

        public static string Roomid { get => roomid; set => roomid = value; }

        public librarian(string r)
        {
            roomid = r;
        }
        public void Approve()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("update Booking set RoomAvailable = 'Approved' where RoomID = '" + roomid + "'", con);
            int ind = cmd.ExecuteNonQuery();
            if (ind != 0)
            {
                MessageBox.Show("Booking Approved"); //display approve message 
            }
            else
            {
                MessageBox.Show("Update Fail"); //display fail message 
            }
            con.Close();
        }

        public void Decline()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("update Booking set RoomAvailable = 'Declined' where RoomID = '" + roomid + "'", con);
            int ind = cmd.ExecuteNonQuery();
            if (ind != 0)  // if ind not equals 0
            {
                MessageBox.Show("Booking Declined"); //display decline message 
            }
            else
            {
                MessageBox.Show("Update Fail"); //display fail message 
            }
            con.Close();
        }
    }
}
