using Final_Project.Dialogs;
using Final_Project.ModelControllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project.ViewControllers {
    public class CustomerViewController : ViewController {

        public CustomerViewController(MainForm mainForm) {
            this.mainForm = mainForm;
            mainForm.lstCustomers.SelectedIndexChanged += lstCustomers_SelectedIndexChanged;
            mainForm.radDisplayAllCustomers.CheckedChanged += radDisplayAllCustomers_CheckedChanged;
            mainForm.radDisplayOutstandingBalance.CheckedChanged += radDisplayOutstandingBalance_CheckedChanged;
            mainForm.txtCustomerFilter.TextChanged += txtCustomerFilter_TextChanged;
        }

        private void txtCustomerFilter_TextChanged(object sender, EventArgs e) {
            loadCustomerList();
        }

        private void radDisplayOutstandingBalance_CheckedChanged(object sender, EventArgs e) {
            if (mainForm.radDisplayAllCustomers.Checked) {
                loadCustomerList();
            }
        }

        private void radDisplayAllCustomers_CheckedChanged(object sender, EventArgs e) {
            if (mainForm.radDisplayOutstandingBalance.Checked) {
                loadCustomerList();
            }
        }

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e) {
            if (mainForm.lstCustomers.SelectedIndex > -1) {
                loadCustomerInformation(mainForm.lstCustomers.SelectedItem.ToString());
            }
        }

        public override void onLogin(String username) {
            mainForm.panelCustomers.Enabled = true;
            loadCustomerList();
        }

        public override void onLogout() {
            mainForm.panelCustomers.Enabled = false;
            mainForm.txtCustomerFilter.Clear();
            resetView();
        }

        public override void resetView() {
            mainForm.lblCustomerID.Text = String.Empty;
            mainForm.lblCustomerName.Text = String.Empty;
            mainForm.lblCustomerTelephone.Text = String.Empty;
            mainForm.lblCustomerRoom.Text = String.Empty;
            mainForm.lblCustomerBalance.Text = String.Empty;
            mainForm.lstCustomers.Items.Clear();
        }

        public String formatCurrency(double value) {
            value = Math.Round(value, 2);
            return value.ToString("C");
        }

        public void loadCustomerList() {
            resetView();
            CustomerModelController modelController = (CustomerModelController)mainForm.getModelController(this.GetType());
            List<String> customerNames;
            if (mainForm.radDisplayAllCustomers.Checked) {
                customerNames = modelController.getCustomerNames(mainForm.txtCustomerFilter.Text);
            } else {
                customerNames = modelController.getCustomersWithBalance(mainForm.txtCustomerFilter.Text);
            }
            
            foreach (String customerName in customerNames) {
                mainForm.lstCustomers.Items.Add(customerName);
            }
        }

        public void loadCustomerInformation(String name) {
            CustomerModelController modelController = (CustomerModelController)mainForm.getModelController(this.GetType());
            HotelDataSet.CustomerRow row = modelController.getCustomerByName(name);
            if (row != null) {
                mainForm.lblCustomerID.Text = row.Id.ToString();
                mainForm.lblCustomerName.Text = row.Name;
                mainForm.lblCustomerTelephone.Text = row.Telephone;
                mainForm.lblCustomerRoom.Text = row.CurrentRoomNumber;
                mainForm.lblCustomerBalance.Text = formatCurrency(row.BalanceDue);
            }
        }

        public void showCustomerManagerDialog()
        {
            if(Application.OpenForms["CustomerManagerDialog"] != null){
                ((CustomerManagerDialog)Application.OpenForms["CustomerManagerDialog"]).BringToFront();
            }else{
                CustomerManagerDialog managerDialog = new CustomerManagerDialog(this);
                managerDialog.Show();
            }
        }


    }
}
