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
    public partial class individualreservepage : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public static string username;

        public individualreservepage(string un)
        {
            InitializeComponent();
            username = un;
        }

        private void individualreservepage_Load(object sender, EventArgs e)
        {
            lblDisplayOwn.Text = username + "'s records"; 
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select RoomType, Room, InitialTime, FinalTime, Date, RoomAvailable from Booking where Username = '" + username + "'", con);
            DataTable dt = new DataTable(); 
            sda.Fill(dt); //fill sda with data in dt

            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide(); //hide this form 
            StudentPage stdp = new StudentPage(username); //declare stdp as an object for class StudentPage 
            stdp.Show(); //show StudentPage form
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
