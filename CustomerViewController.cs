using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project.ViewController
{
    public class CustomerViewController : ViewController
    {
        // private object mainForm;

        public CustomerViewController(MainForm mainForm)
        {
            this.mainForm = mainForm;
            mainForm.lstCustomers.SelectedIndexChanged += lstCustomer_SelectedIndexChanged;
            mainForm.radAll.CheckedChanged += radAll_CheckedChanged;
            mainForm.radBalance.CheckedChanged += radBalance_CheckedChanged;
            mainForm.txtFilter.TextChanged += txtFiter_TextChanged;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            loadCustomerList();
        }

        private void radBalance_CheckedChanged(object sender, EventArgs e)
        {
            if (mainForm.radAll.Checked)
            {
                loadCustomerList();
            }

        }

        private void IstCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mainForm.lstCustomer.SelectedIndex > -1)
            {
                loadingCustomerInformation(mainForm.lstCustomer.SelectedItem.ToString());
            }
        }

        private void radAll_CheckedChanged(object sender, EventArgs e)
        {
            if (mainForm.radBalance.Checked)
            {
                loadCustomerList();
            }

        }

        public override void onLogin(String username)
        {
            mainForm.panelCustomers.Enabled = true;
            loadCustomerList();
        }

        public override void onLogout()
        {
            mainForm.panelCustomer.Enabled = false;
            mainForm.txtFilter.Clear();
            resetView();

        }

        public override void resetView()
        {
            mainForm.lblCustomerID.Text = String.Empty;
            mainForm.lblName.Text = String.Empty;
            mainForm.lblPhoneNumber.Text = String.Empty;
            mainForm.lblCustomerRoom.Text = String.Empty;
            mainForm.lblBalance.Text = String.Empty;
            mainForm.lstCustomer.Items.Clear();
        }

        public String formatCurreency(double value)
        {
            value = Math.Round(value, 2);
            return value.ToString("C");
        }
        public void loadCustomerList()
        {
            resetView();
            CustomerModelController modelController = (CustomerModelController)mainForm.getModelController(this.GetType);
            List<String> customerNames;
            if (mainForm.radDisplayAllCustomers.Checked)
            {
                customerNames = modelController.getCustomerNames(mainForm.txtFilter.Text);
            }
            else
            {
                customerNames = modelController.getCustomerWithBalance(mainForm.txtFilter);
            }
            foreach (String customerName in customerNames)
            {
                mainForm.lstCustomers.Items.Add(customerNames);
            }
        }

        public void loadCustomerInformation(String name)
        {
            CustomerModelController modelController = (CustomerModelController)mainForm.getModelController(this.GetType());
            CustomerDataSet.CustomerRow row = modelController.getCustomerByName(name);
            if (row != null)
            {
                mainForm.lblCustomerID.Text = row.Id.ToString();
                mainForm.lblCustomerName.Text = row.Name;
                mainForm.lblPhoneNumber.Text = row.Phone_Number;
                mainForm.lblCustomerRoom.Text = row.CurrentRoomNumber;
                mainForm.lblBalance.Text = formatCurrency(row.BalanceDue);

            }
        }

        public void showCustomerManagerDialog()
        {
            if (Application.OpenForms["CustomerManagerDialog"] != null)
            {
                ((CustomerManagerDialog)Application.OpenForms["CustomerManagerDialog"].BringToFront();
            }
            else
            {
                CustomerManagerDialog managerDialog = new showCustomerManagerDialog(this);
                managerDialog.Show();
            }
        }
    }

}