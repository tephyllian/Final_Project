using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project.ModelControllers;
using Final_Project.Dialogs;

namespace Final_Project.ViewControllers {
    public class EmployeeViewController : ViewController {

        public EmployeeViewController(MainForm mainForm) {
            this.mainForm = mainForm;
            mainForm.lstEmpoloyees.SelectedIndexChanged += LstEmpoloyees_SelectedIndexChanged;
        }

        private void LstEmpoloyees_SelectedIndexChanged(object sender, EventArgs e){
            if (mainForm.lstEmpoloyees.SelectedIndex > -1)
            {
                EmployeeModelController modelController = (EmployeeModelController)mainForm.getModelController(this.GetType());
                HotelDataSet.StaffRow selectedRow = modelController.getEmployeeByName(mainForm.lstEmpoloyees.SelectedItem.ToString());
                if(selectedRow != null)
                {
                    mainForm.lblEmployeeID.Text = selectedRow.Id.ToString();
                    mainForm.lblEmployeeName.Text = selectedRow.Name;
                    mainForm.lblEmployeePosition.Text = selectedRow.Position;
                    mainForm.lblEmployeeTelephone.Text = selectedRow.Telephone;
                    mainForm.lblEmployeeDateHired.Text = selectedRow.DateHired.ToShortDateString();
                    mainForm.lblEmployeeStatus.Text = selectedRow.Status;
                }
            }
        }

        public override void onLogin(String username) {
            mainForm.panelEmployees.Enabled = true;
            populateEmployeeList();
        }

        public override void onLogout() {
            mainForm.panelEmployees.Enabled = false;
            mainForm.lstEmpoloyees.Items.Clear();

            if(Application.OpenForms["EmployeeManagerDialog"] != null){
                ((EmployeeManagerDialog)Application.OpenForms["EmployeeManagerDialog"]).Close();
            }
        }

        public void showEmployeeManagerDialog()
        {
            if (Application.OpenForms["EmployeeManagerDialog"] != null)
            {
                ((EmployeeManagerDialog)Application.OpenForms["EmployeeManagerDialog"]).BringToFront();
            }else{
                EmployeeManagerDialog managerDialog = new EmployeeManagerDialog(this);
                managerDialog.Show();
            }
        }

        public override void resetView() {
            mainForm.lstEmpoloyees.Items.Clear();
            mainForm.lblEmployeeID.Text = String.Empty;
            mainForm.lblEmployeeName.Text = String.Empty;
            mainForm.lblEmployeePosition.Text = String.Empty;
            mainForm.lblEmployeeTelephone.Text = String.Empty;
            mainForm.lblEmployeeStatus.Text = String.Empty;
            mainForm.lblEmployeeDateHired.Text = String.Empty;
        }

        public void populateEmployeeList(){
            mainForm.lstEmpoloyees.Items.Clear();
            EmployeeModelController modelController = (EmployeeModelController)mainForm.getModelController(this.GetType());
            foreach(String employeeName in modelController.getEmployeeNames())
            {
                mainForm.lstEmpoloyees.Items.Add(employeeName);
            }
        }
    }
}
