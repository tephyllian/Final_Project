using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class ViewAllLoginsForm : Form
    {
        public ViewAllLoginsForm()
        {
            InitializeComponent();
        }

        private void ViewAllLoginsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginsDataSet.Logins' table. You can move, or remove it, as needed.
            this.loginsTableAdapter.Fill(this.loginsDataSet.Logins);

        }
    }
}
