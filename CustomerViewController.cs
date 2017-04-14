using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
     class CustomerViewController:ViewController
    {
        public CustomerViewController(MainForm mainForm)
        {
            mainForm.lstCustomers.SelectedIndexChanged += lstCustomer_SelectedIndexChanged;
            mainForm.radDisplayAllCustomers.CheckedChanged += radDisplayAllCustomer_CheckedChanged;
            mainForm.radDisplayOutstandingBalance.CheckedChanged += radDisplayOutstandingBalance_CheckedChanged;
            mainForm.txtCustomerFilter.TextChanged += txtCustomerFiter_TextChanged;
        }
    }
}
