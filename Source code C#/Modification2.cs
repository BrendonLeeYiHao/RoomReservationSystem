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
    public partial class Modification2 : Form
    {
        public Modification2()
        {
            InitializeComponent();
        }

        public Modification2(string user)
        {
            InitializeComponent();
            username = user;
            DTPInitial.Value = DateTime.Now;
            dateandtime = DTPInitial.Value.ToString(); //convert datetime.now to a string

            DTPFinal.Value = DateTime.Now;
            dateandtime2 = DTPFinal.Value.ToString();

            DTPDate.Value = DateTime.Now;
            dateandtime3 = DTPDate.Value.ToString();

            RoomID = "0";                   // set default value for roomid, roomonly, chooseroomtype to prevent null variable
            roomonly = "0";
            chooseroomtype = "0";

            //display booking table in data grid view
            con.Open();
            da = new SqlDataAdapter("select RoomID, RoomType, Room, InitialTime, FinalTime, Date, RoomAvailable from Booking where Username = '" + username + "' order by RoomAvailable", con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dGVMoR.DataSource = dt;

        }

        //public string is used so that the labels can display the data in text form
        public static string username;
        public int index;
        public int ind;
        public string time;
        public string time2;
        public string time3;
        public string dateandtime;
        public string dateandtime2;
        public string dateandtime3;
        public static string chooseroomtype;
        public static string roomonly;
        public string requestpar;
        public string RoomID;
        public string roomstatus;
        SqlDataAdapter da;
        DataTable dt;

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        private void Modification2_Load(object sender, EventArgs e)
        {
            cmboxR.SelectedIndex = 0; //set default value for combobox
            cmboxRT.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           con.Open();
            if (index >= 0)
            { //to change the data grid view value to be the same as in the database without refreshing it for aesthetic purposes
                DataGridViewRow newdata = dGVMoR.Rows[index];
                newdata.Cells[1].Value = cmboxRT.Text;
                newdata.Cells[2].Value = cmboxR.Text;
                newdata.Cells[3].Value = dateandtime;
                newdata.Cells[4].Value = dateandtime2;
                newdata.Cells[5].Value = dateandtime3;
                newdata.Cells[6].Value = "Pending";
            }

           con.Close();

           if (roomstatus == "Pending" || roomstatus == "Declined")
           {
                MessageBox.Show("Update Fail. Existing booking does not exist!"); //room that are in pending/ declined cannot be updated
                con.Close();
           }

           else
           { //method modify() called to update the data into the database
               requestpar = "Approved";
               bookingroom2 upd = new bookingroom2(cmboxRT.Text, cmboxR.Text, username, DTPInitial.Text, DTPFinal.Text, DTPDate.Text, requestpar, RoomID);
               upd.Modify();
           }

        }

        private void grpboxOld_Enter(object sender, EventArgs e)
        {

        }

        private void dGVMoR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {//method delete() called to delete the data from the database
            index = dGVMoR.CurrentCell.RowIndex;
            dGVMoR.Rows.RemoveAt(index);
     
            bookingroom2 del = new bookingroom2(cmboxRT.Text, cmboxR.Text, username, DTPInitial.Text, DTPFinal.Text, DTPDate.Text, requestpar, RoomID);
            del.Delete();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            StudentPage std = new StudentPage(username); //proceed to student page when button is clicked
            this.Hide();
            std.Show();
        }

        private void cmboxRT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRef_Click(object sender, EventArgs e)
        {//display the table in data grid view
            con.Open();
            da = new SqlDataAdapter("select RoomID, RoomType, Room, InitialTime, FinalTime, Date, RoomAvailable from Booking where Username = '" + username + "' order by RoomAvailable", con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dGVMoR.DataSource = dt;
        }

        private void dGVMoR_CellClick(object sender, DataGridViewCellEventArgs e)
        {//when the row in the data grid view is selected, the labels can display the data in text
            index = e.RowIndex;
            if (index>=0)
            {
                DataGridViewRow row = dGVMoR.Rows[index];
                RoomID = row.Cells[0].Value.ToString();

                chooseroomtype = row.Cells[1].Value.ToString();
                lblDtRT.Text = row.Cells[1].Value.ToString();
                cmboxRT.Text = row.Cells[1].Value.ToString();

                roomonly = row.Cells[2].Value.ToString();
                lblDtR.Text = row.Cells[2].Value.ToString();
                cmboxR.Text = row.Cells[2].Value.ToString();

                lblDtIT.Text = row.Cells[3].Value.ToString();
                time = row.Cells[3].Value.ToString();
                DTPInitial.Value = DateTime.ParseExact(time, "HH:mm", CultureInfo.InvariantCulture);

                lblDtFT.Text = row.Cells[4].Value.ToString();
                time2 = row.Cells[4].Value.ToString();
                DTPFinal.Value = DateTime.ParseExact(time2, "HH:mm", CultureInfo.InvariantCulture);

                lblDtD.Text = row.Cells[5].Value.ToString();
                time3 = row.Cells[5].Value.ToString();
                DTPDate.Value = DateTime.ParseExact(time3, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                roomstatus = row.Cells[6].Value.ToString();
                lblDtRA.Text = row.Cells[6].Value.ToString();
            }
            
        }

        private void cmboxRT_TextChanged(object sender, EventArgs e)
        {
            cmboxR.Items.Clear();

            if (cmboxRT.Text == "Amber")    //when amber is selected, only amber rooms are available to be selected
            {
                for (int i = 1; i <= 5; i++)
                {
                    cmboxR.Items.Add("Amber" + i.ToString());
                }
                cmboxR.SelectedIndex = 0;
            }
            else if (cmboxRT.Text == "BlackThorn")    //when blackthorn is selected, only blackthorn rooms are available to be selected
            {
                for (int i = 1; i <= 4; i++)
                {
                    cmboxR.Items.Add("BlackThorn" + i.ToString());
                }
                cmboxR.SelectedIndex = 0;
            }
            else if (cmboxRT.Text == "Cedar")   //when cedar is selected, only cedar rooms are available to be selected
            {
                for (int i = 1; i <= 6; i++)
                {
                    cmboxR.Items.Add("Cedar" + i.ToString());
                }
                cmboxR.SelectedIndex = 0;
            }
            else if (cmboxRT.Text == "Daphne")  //when daphne is selected, only daphne rooms are available to be selected
            {
                for (int i = 1; i <= 5; i++)
                {
                    cmboxR.Items.Add("Daphne" + i.ToString());
                }
                cmboxR.SelectedIndex = 0;
            }

        }

        private void lblDtRA_Click(object sender, EventArgs e)
        {

        }

        private void DTPInitial_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dGVMoR.Rows.Count; i++)
            {
                DataGridViewRow newdata = dGVMoR.Rows[index];   //to prevent code error when click the row outside of the table
                dateandtime = DTPInitial.Value.ToString("HH:mm");
            }
        }

        private void DTPFinal_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dGVMoR.Rows.Count; i++)     //to prevent code error when click the row outside of the table
            {
                DataGridViewRow newdata = dGVMoR.Rows[index];
                dateandtime2 = DTPFinal.Value.ToString("HH:mm");
            }
        }

        private void DTPDate_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dGVMoR.Rows.Count; i++)         //to prevent code error when click the row outside of the table
            {
                DataGridViewRow newdata = dGVMoR.Rows[index];
                dateandtime3 = DTPDate.Value.ToString("dd/MM/yyyy");
            }
        }

        private void grpboxNew_Enter(object sender, EventArgs e)
        {

        }
    }
}
    
