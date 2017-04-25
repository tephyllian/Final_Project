using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Final_Project
{
 public class LoginViewController: ViewController
    {
  //private MainForm mainForm;
    public LoginViewController(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }
        public override void onLogin(String username)
        {
            mainForm.btnLogin.Enabled = false;
            mainForm.btnLogout.Enabled = true;
            mainForm.txtUsename.Enabled = false;
            mainForm.txtPassword.Enabled = false;
            mainForm.txtUsername.BackColor = Color.Green;
            mainForm.lblStatus.Text = "You are logged in:" + username;
        }

        public override void onLogout()
        {
            resetView();
        }

        public override void resetView()
        {
            mainForm.btnLogin.Enabled = true;
            mainForm.btnLogout.Enabled = false;
            mainForm.txtUsername.Clear();
            mainForm.txtPassword.Clear();
            mainForm.txtUsername.Enabled = true;
            mainForm.txtPassword.Enabled = true;
            mainForm.txtUsename.BackColor = Color.Blue;
            mainForm.lblLoginStatus.Text = " You are not logged in";

        }
    }
}
