using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOPAssignment
{
    public partial class LibrarianPage : Form
    {
        public static string username;

        public LibrarianPage(string i)
        {
            InitializeComponent();
            username = i;
        }
        private void LibrarianPage_Load(object sender, EventArgs e)
        {
            lblHelloLibrarian.Text = "WELCOME " + username; //display username in the label
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you wish to log out?", "Log out", MessageBoxButtons.YesNo); //get confirmation from user to log out
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void btnViewDaily_Click(object sender, EventArgs e)
        {
            this.Hide();
            Librarian_Daily_Report ldr = new Librarian_Daily_Report(username); //proceed to librarian daily report user interface
            ldr.Show();

        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            this.Hide();
            Librarian_Monthly_Report lmr = new Librarian_Monthly_Report(username); //proceed to librarian monthly report user interface
            lmr.Show();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            this.Hide();
            Request2 req = new Request2(username); //proceed to librarian accept/ decline room request user interface
            req.Show();
        }
    }
}
