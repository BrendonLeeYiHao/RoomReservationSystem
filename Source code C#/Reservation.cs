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
   
    public partial class Reservation : Form
    {
        public static string chooseroomtype;
        public static string roomonly;
        public static string username;

        public Reservation(string u)
        {
            InitializeComponent();
            username = u;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string requestpar = "Approved";     //declare requestpar and stores string Approved

            chooseroomtype = cmbRoomType.SelectedItem.ToString();     //item selected in comboBox1 is stored in chooseroomtype
            roomonly = cmbRoom.SelectedItem.ToString();       //item selected in comboBox2 is stored in roomonly

            bookingroom res = new bookingroom(chooseroomtype, roomonly, username, DTPInitial.Text, DTPFinal.Text, DTPDate.Text, requestpar);   //declare res as object of class bookingroom with 7 arguments
            res.studentreservation();  //execute member method studentreservation()
        }


        private void Reservation_Load(object sender, EventArgs e)
        {
            cmbRoomType.SelectedIndex = 0;    //when this form loads, first item of comboBox1 is selected
            cmbRoom.SelectedIndex = 0;    //when this form loads, first item of comboBox2 is selected
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();    //hide Reservation form
            StudentPage sp = new StudentPage(username); //declare sp as object of class StudentPage with 1 argument in StudentPage constructor
            sp.Show();  //display StudentPage form
        }

        private void DTPDate_ValueChanged(object sender, EventArgs e)
        {

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbRoom.Items.Clear();    //Clear all items in comboBox2

            if (cmbRoomType.SelectedItem.ToString() == "Amber")   //if selected item in comboBox1 = Amber
            {
                for (int i = 1; i <= 5; i++)    //starting int i = 1,  if i > 5, break from loop   ,for each loop i increase by 1
                {
                    cmbRoom.Items.Add("Amber" + i.ToString());    //Add items to comboBox2 (First item is Amber1)
                }
                cmbRoom.SelectedIndex = 0;    //after loop breaks, select first item in comboBox2
            }
            else if (cmbRoomType.SelectedItem.ToString() == "BlackThorn")     //if selected item in comboBox1 = BlackThorn
            {
                for (int i = 1; i <= 4; i++)    //starting int i = 1,  if i > 4, break from loop   , for each loop i increase by 1
                {
                    cmbRoom.Items.Add("BlackThorn" + i.ToString());   //Add items to comboBox2 (First item is BlackThorn1)
                }
                cmbRoom.SelectedIndex = 0;    //after loop breaks, select first item in comboBox2
            }
            else if (cmbRoomType.SelectedItem.ToString() == "Cedar")  //if selected item in comboBox1 = Cedar
            {
                for (int i = 1; i <= 6; i++)    //starting int i = 1,  if i > 6, break from loop    , for each loop i increase by 1
                {
                    cmbRoom.Items.Add("Cedar" + i.ToString());    //Add items in comboBox2 (First item is Cedar1)
                }
                cmbRoom.SelectedIndex = 0;    //after loop breaks, select first item in comboBox2
            }
            else if (cmbRoomType.SelectedItem.ToString() == "Daphne") //if selected item in comboBox1 = Daphne
            {
                for (int i = 1; i <= 5; i++)    //starting int i = 1,  if i > 5, break from loop   , for each loop i increase by 1
                {
                    cmbRoom.Items.Add("Daphne" + i.ToString());   //Add items in comboBox2 (First item is Daphne1)
                }
                cmbRoom.SelectedIndex = 0;    //after loop breaks, select first item in comboBox2
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DTPInitial_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select RoomType, Room, InitialTime, FinalTime, Date, RoomAvailable, Username from Booking where RoomAvailable = 'Approved' and Date = '" + DTPsearchdate.Text + "'", con);  //Select data from each column from Booking table where RoomAvailable column = Approved and Date = datetimepicker
            DataTable dt = new DataTable();
            da.Fill(dt);    //Command linked to the database
            con.Close();

            dataGridView1.DataSource = dt;
        }
    }
}
