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
    public partial class Request2 : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public static string username;
        public string roomid;
        public string room;

        public Request2(string un)
        {
            InitializeComponent();
            username = un;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            librarian acpt = new librarian(roomid);
            acpt.Approve();
        }

        private void rbtnA_CheckedChanged(object sender, EventArgs e)
        {//display table with Amber room type that are pending only in the data grid view
            room = "Amber";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select RoomID, RoomType, Room, InitialTime, FinalTime, Date, RoomAvailable, Username from Booking where RoomType = '" + room + "' and RoomAvailable = 'Pending' order by RoomType ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dGVRR.DataSource = dt;
        }

        private void rbtnB_CheckedChanged(object sender, EventArgs e)
        {//display table with BlackThorn room type that are pending only in the data grid view
            room = "BlackThorn";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select RoomID, RoomType, Room, InitialTime, FinalTime, Date, RoomAvailable, Username from Booking where RoomType = '" + room + "' and RoomAvailable = 'Pending' order by RoomType ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dGVRR.DataSource = dt;
        }

        private void rbtnC_CheckedChanged(object sender, EventArgs e)
        {//display table with Cedar room type that are pending only in the data grid view
            room = "Cedar";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select RoomID, RoomType, Room, InitialTime, FinalTime, Date, RoomAvailable, Username from Booking where RoomType = '" + room + "' and RoomAvailable = 'Pending' order by RoomType ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dGVRR.DataSource = dt;
        }

        private void rbtnD_CheckedChanged(object sender, EventArgs e)
        {//display table with Daphne room type that are pending only in the data grid view
            room = "Daphne";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select RoomID, RoomType, Room, InitialTime, FinalTime, Date, RoomAvailable, Username from Booking where RoomType = '" + room + "' and RoomAvailable = 'Pending' order by RoomType ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dGVRR.DataSource = dt;
        }

        private void dGVRR_CellClick(object sender, DataGridViewCellEventArgs e)
        {//display the value from the data grid view into the label text
            int index = e.RowIndex;
            if (index >= 0)
            {
                
                DataGridViewRow row = dGVRR.Rows[index];
                roomid = row.Cells[0].Value.ToString();
                lblDtRT.Text = row.Cells[1].Value.ToString();
                lblDtR.Text = row.Cells[2].Value.ToString();
                lblDtIT.Text = row.Cells[3].Value.ToString();
                lblDtFT.Text = row.Cells[4].Value.ToString();
                lblDtD.Text = row.Cells[5].Value.ToString();
                lblDtU.Text = row.Cells[7].Value.ToString();
            }
            
        }

        private void btnDcln_Click(object sender, EventArgs e)
        {
            librarian dcl = new librarian(roomid);  //method declined() is called to decline the room request
            dcl.Decline();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LibrarianPage lbp = new LibrarianPage(username);    //proceed to librarian main page when button is clicked
            lbp.Show();
            this.Hide();
        }

        private void btnRef_Click(object sender, EventArgs e)
        { //display booking table in the data grid view
            SqlDataAdapter da = new SqlDataAdapter("select RoomID, RoomType, Room, InitialTime, FinalTime, Date, RoomAvailable, Username from Booking where RoomType = '" + room + "' and RoomAvailable = 'Pending' order by RoomType ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dGVRR.DataSource = dt;
        }
    }
}
