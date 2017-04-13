using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Main : Form
    {
        private LoginsDataSetTableAdapters.LoginsTableAdapter loginAdapter =
            new LoginsDataSetTableAdapters.LoginsTableAdapter();

        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            panelLogin.Dock = DockStyle.Fill;
            //Remove following lines upon completion
            panelLogin.Hide();
            panelMain.Show();
            panelMain.Dock = DockStyle.Fill;

            //Uncomment following line upon completion
            this.AcceptButton = btnLogin;
        }

        private void viewAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Create an  the logins form
            ViewAllLoginsForm myLoginsForm = new ViewAllLoginsForm();

            //Display the form
            myLoginsForm.ShowDialog();
        }

        private void newLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Creates new login
            NewLoginsForm myNewLogin = new NewLoginsForm();

            //Displays
            myNewLogin.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            int password;
            string userName = txtUsername.Text;

            if (userName == "")
            {
                errorProvider.SetError(txtUsername, "Username must be put");
                return;
            }

            if (!(userName.Contains("@")) || !(userName.Contains(".")))
            {
                errorProvider.SetError(txtUsername, "The username must be in a form of address");
                return;
            }
            if (!(int.TryParse(txtPassword.Text, out password)))
            {
                errorProvider.SetError(txtPassword, " Password used must be in ingeter form");
                return;
            }
            // to check for successful validation
            if (loginAdapter.Search(loginAdapter.GetData(), userName, password) > 0)
            {
                panelLogin.Hide();
                panelMain.Show();
                panelMain.Dock = DockStyle.Fill;
                this.AcceptButton = null;
                txtPassword.Clear();
                txtUsername.Clear();
            }
            else if (loginAdapter.SearchUsername(loginAdapter.GetData(), userName) > 0)
            {
                lblStatus.Text = "password is invalid";
            }
            else
            {
                lblStatus.Text = "Inputs not valid check again";
            }
    }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelLogin.Show();
            panelMain.Hide();
            panelMain.Dock = DockStyle.Fill;
            this.AcceptButton = btnLogin;
        }

        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAllStaffForm myViewAllStaffForm = new ViewAllStaffForm();

            //Display
            myViewAllStaffForm.ShowDialog();
        }
    }
}
