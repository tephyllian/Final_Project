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
    public partial class EmployeeManagerDialog : Form
    {

        private EmployeeViewController viewController = null;

        public EmployeeManagerDialog(EmployeeViewController viewController)
        {
            InitializeComponent();
            this.viewController = viewController;
        }

        private void EmployeeManagerDialog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.hotelDataSet.Staff);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                employeeTable.EndEdit();
                staffTableAdapter.Update(hotelDataSet);
                MessageBox.Show("The changes have been saved.", "Successful Update", MessageBoxButtons.OK);
            }catch(Exception saveException){
                MessageBox.Show(saveException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void employeeTable_DataError(object sender, DataGridViewDataErrorEventArgs e){
            e.ThrowException = false;
        }

        private void EmployeeManagerDialog_FormClosing(object sender, FormClosingEventArgs e){
            if(MessageBox.Show("Warning: any unsaved changes will be lost.\nDo you want to save before exiting?", "Save Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                employeeTable.EndEdit();
                staffTableAdapter.Update(hotelDataSet);
            }

            if(viewController != null){
                viewController.populateEmployeeList();
            }
        }
    }
}
