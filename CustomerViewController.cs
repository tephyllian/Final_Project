using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
     class CustomerViewController
    {
        public CustomerViewController(MainForm mainForm)
        {
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
            if (MainForm.radAll.Checked)
            {
                loadCustomerList();
            }

        }

        private void IstCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(mainForm.lstCustomer.SelectedIndex > -1)
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
       
    }
}
