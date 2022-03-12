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
    public partial class Librarian_Daily_Report : Form
    {
        public static string username;
        
        public Librarian_Daily_Report(string un)
        {
            InitializeComponent();
            username = un;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            //display the table with following columns attributes in data grid view
            SqlDataAdapter da = new SqlDataAdapter("select RoomType, Room, InitialTime, FinalTime, Date, RoomAvailable, Username from Booking where RoomAvailable = 'Approved' and Date = '" + dateTimePicker1.Text +"'",con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Librarian_Daily_Report_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarianPage lbp = new LibrarianPage(username); //proceed to librarian page when button is clicked
            lbp.Show();
        }
    }
}
