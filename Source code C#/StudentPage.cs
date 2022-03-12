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
    public partial class StudentPage : Form
    {
        public static string username;

        public StudentPage(string s)
        {
            InitializeComponent();
            username = s;
        }

        private void StudentPage_Load(object sender, EventArgs e)
        {
            lblHelloUser.Text = "WELCOME " + username;  //display WELCOME message in label
        }

        private void lblHelloUser_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Do you wish to log out?", "Log out", MessageBoxButtons.YesNo); //Prompt user to select yes or no 
            if (dialogresult == DialogResult.Yes)   //if yes
            {
                this.Hide();    //hide StudentPage form
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {           
            this.Hide();    //hide StudentPage form
            Reservation rsv = new Reservation(username);    //declare rsv as object of class Reservation with 1 string argument in Reservation constructor
            rsv.Show(); //display Reservation form

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            this.Hide();    //hide StudentPage form
            Modification2 mdf = new Modification2(username);        //declare mdf as object of class Modification2 with 1 string argument in Modification2 constructor
            mdf.Show(); //display Modification2 form
        }

        private void btnViewOwn_Click(object sender, EventArgs e)
        {
            this.Hide();    //hide StudentPage form
            individualreservepage indrsv = new individualreservepage(username);     //declare indrsv as object of class individualreservepage with 1 string argument in individualreservepage constructor
            indrsv.Show();  //display individualreservepage form
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();    //hide StudentPage form
            UpdateStudentDetails usd = new UpdateStudentDetails(username);      //declare usd as object of class UpdateStudentDetails with 1 string argument in UpdateStudentDetails constructor
            usd.Show();   //display UpdateStudentDetails form
        }
    }
}
