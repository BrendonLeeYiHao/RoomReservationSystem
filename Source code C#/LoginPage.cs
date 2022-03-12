using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace IOOPAssignment
{
    public partial class LoginPage : Form
    {
        public static string usertypetext;
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        { 
            if (radioStudent.Checked)
            {
                usertypetext = "Student";
            }
            else if (radioLibrarian.Checked)
            {
                usertypetext = "Admin";
            }

            user log = new user(TextBoxUser.Text, TextBoxPass.Text, usertypetext); //declare log as an object for class user with 3 string arguments in user constructor
            log.Login();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void radioLibrarian_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioStudent_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide(); //hide this form
            studentregistration sr = new studentregistration(); //declare sr as an object for class studentregistration
            sr.Show(); //show studentregistration form 
            
            
            
        }
    }
}
