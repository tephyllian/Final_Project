using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Final_Project.ViewControllers {
    public class LoginViewController : ViewController {
        //private MainForm mainForm;

        public LoginViewController(MainForm mainForm) {
            this.mainForm = mainForm;
        }

        public override void onLogin(String username) {
            mainForm.btnLogin.Enabled = false;
            mainForm.btnLogout.Enabled = true;
            mainForm.txtUsername.Enabled = false;
            mainForm.txtPassword.Enabled = false;
            mainForm.txtUsername.BackColor = Color.LightGreen;
            mainForm.lblLoginStatus.Text = "Logged in: " + username;
        }

        public override void onLogout() {
            resetView();
        }

        public override void resetView() {
            mainForm.btnLogin.Enabled = true;
            mainForm.btnLogout.Enabled = false;
            mainForm.txtUsername.Clear();
            mainForm.txtPassword.Clear();
            mainForm.txtUsername.Enabled = true;
            mainForm.txtPassword.Enabled = true;
            mainForm.txtUsername.BackColor = Color.White;
            mainForm.lblLoginStatus.Text = "Not Logged In";
        }

    }
}
