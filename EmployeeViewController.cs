using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.ViewControllers 
{
  public class EmployeeViewController : ViewController
    {
        public EmployeeViewController(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }

        public override void onLogin(String username)
        {
            mainForm.panelEmployees.Enabled = true;
        }

        public override void onLogout()
        {
            mainForm.panelEmployees.Enabled = false;
        }

        public override void resetView()
        {

        }

        internal void showEmployeeManagerDialog()
        {
            throw new NotImplementedException();
        }
    }

}
