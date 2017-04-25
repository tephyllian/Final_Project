using Final_Project.ModelControllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project.Dialogs
{
    public partial class CheckInDialog : Form
    {
        CustomerModelController customerModelController = null;
        RoomModelController roomModelController = null;

        public CheckInDialog(CustomerModelController customerModelController, RoomModelController roomModelController)
        {
            InitializeComponent();
            this.customerModelController = customerModelController;
            this.roomModelController = roomModelController;
        }

        private void radNewCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (radNewCustomer.Checked)
            {
                groupNewCustomer.Enabled = true;
            }else{
                groupNewCustomer.Enabled = false;
            }
        }

        private void radExistingCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (radExistingCustomer.Checked)
            {
                groupExistingCustomer.Enabled = true;
            }else{
                groupExistingCustomer.Enabled = false;
            }
        }
    }
}
