using Final_Project.ViewControllers;
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
    public partial class CustomerManagerDialog : Form
    {

        private CustomerViewController viewController = null;

        public CustomerManagerDialog(CustomerViewController viewController)
        {
            InitializeComponent();
            this.viewController = viewController;
        }

        private void CustomerManagerDialog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.hotelDataSet.Customer);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try{
                customerTableAdapter.Update(hotelDataSet);
                MessageBox.Show("The changes have been saved.", "Successful Update", MessageBoxButtons.OK);
            }catch(Exception saveException){
                MessageBox.Show(saveException.Message, "Error");
            }
        }

        private void CustomerManagerDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Warning: any unsaved changes will be lost.\nDo you want to save before exiting?", "Save Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                customerTable.EndEdit();
                customerTableAdapter.Update(hotelDataSet);
            }

            if (viewController != null){
                viewController.loadCustomerList();
            }
        }

        private void customerTable_DataError(object sender, DataGridViewDataErrorEventArgs e){
            e.ThrowException = false;
        }
    }
}
