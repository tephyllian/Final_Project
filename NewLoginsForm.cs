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
    public partial class NewLoginsForm : Form
    {
        private LoginsDataSetTableAdapters.LoginsTableAdapter loginAdapter =
            new LoginsDataSetTableAdapters.LoginsTableAdapter();

        public NewLoginsForm()
        {
            InitializeComponent();
        }

        private void NewLoginsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            int password;
            string userName = txtUsername.Text;

            //Input validation
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
            if(!(int.TryParse(txtPassword.Text, out password)))
                {
                errorProvider.SetError(txtPassword, " Password used must be in ingeter form");
                return;
                }
            // to check for successful validation
            try
            {
                loginAdapter.Insert(userName, password);
                lblStatus.Text = "New user login is added";
            }
            catch
            {
                lblStatus.Text = " Please check again error while creating new login";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
