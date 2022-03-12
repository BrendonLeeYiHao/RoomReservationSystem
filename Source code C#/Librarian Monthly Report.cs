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

    public partial class Librarian_Monthly_Report : Form
    {
        public static string username;
        public Librarian_Monthly_Report(string un)
        {
            InitializeComponent();
            username = un;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select RoomType, Room, InitialTime, FinalTime, Date, RoomAvailable, Username from Booking where RoomAvailable = 'Approved' and Date like '___" + dateTimePicker1.Text + "%'", con);
            DataTable dt = new DataTable(); 
            da.Fill(dt); //fill da with data in dt 
            con.Close();

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Librarian_Monthly_Report_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide(); //hide form 
            LibrarianPage lbp = new LibrarianPage(username); //declare lbp as object for class LibrarianPage 
            lbp.Show(); //show LibrarianPage form

        }
    }
}
