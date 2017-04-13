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
    public partial class ViewAllStaffForm : Form
    {
        private StaffDataSetTableAdapters.StaffTableAdapter adapter;
        private bool formLoading = true;

        public ViewAllStaffForm()
        {
            InitializeComponent();
        }

        private void ViewAllStaffForm_Load(object sender, EventArgs e)
        {
            adapter = new StaffDataSetTableAdapters.StaffTableAdapter();
            UpdateForm();

            dgvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStaff.MultiSelect = false;
        }
        public void UpdateForm()
        {
            cboNames.ComboBox.DataSource = adapter.GetData();
            cboNames.ComboBox.DisplayMember = "Name";
            cboNames.ComboBox.ValueMember = "Id";
            cboNames.ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNames.SelectedIndex = -1;

            dgvStaff.DataSource = adapter.GetData();
            formLoading = false;
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            dgvStaff.DataSource = adapter.GetData();
        }
        private void cboNames_SelectedIdexChanged(object sender, EventArgs e)
        {
            if (!formLoading)
            {
                int selectedId = (int)cboNames.ComboBox.SelectedValue;
                dgvStaff.DataSource = GetById(selectedId);

            }
        }
        private DataTable GetById(int pId)
        {
            DataTable table = adapter.GetData();
            table.DefaultView.RowFilter = "Id = " + pId;
            return table;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";

            if(dgvStaff.SelectedRows.Count > 0)
            {
                DialogResult dr =
                    MessageBox.Show("If you delete the staff he or she will be removed permanently. Do you still want to continue with the process",
                    "Confirm Delete", MessageBoxButtons.YesNoCancel);

                if(dr == DialogResult.Yes)
                {
                    int selectedId = (int)dgvStaff.SelectedRows[0].Cells[0].Value;

                    if(adapter.Delete(selectedId) > 0)
                    {
                        dgvStaff.DataSource = adapter.GetData();
                        formLoading = true;
                        UpdateForm();
                        lblStatus.Text = "staff removed";
                    }
                    else
                    {
                        lblStatus.Text = " Staff is not selected";
                    }
                }

            }

        }
    }

    }

