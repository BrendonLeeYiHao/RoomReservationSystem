using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOPAssignment
{
    public partial class studentregistration : Form
    {
        public static string becomeexist;
        public studentregistration()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            becomeexist = "Student";    //becomeexist stores string Student
            user reg = new user(txtnewname.Text, txtnewpass.Text, txtnewemail.Text, txtnewphone.Text, becomeexist);    //declare reg as an object of class user with 5 string arguments in user constructor
            reg.Register();    //execute member method Register()
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();    //hide studentregistration form
            LoginPage lp = new LoginPage();    //declare lp as object of class LoginPage 
            lp.Show();  //display LoginPage form
        }

        private void studentregistration_Load(object sender, EventArgs e)
        {

        }
    }
}
