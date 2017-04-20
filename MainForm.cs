using Final_Project.ViewController;
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

namespace Final_Project
{
public partial class MainForm : Form
{
    private LoginViewController loginController;
    private LoginModelController loginModelController;
    private EmployeeViewController employeeController;
    private EmployeeModelController employeeModelController;
    private RoomViewController roomController;
    private RoomModelController roomModelController;
    private CustomerViewController customerController;
    private CustomerModelController customerModelController;

        private ErrorProvider errLogin;



    public MainForm()
    { 
        InitializeComponent();      
    }
    private void Main_Load(object sender, EventArgs e)
    {
            // TODO: This line of code loads data into the 'roomDataSet.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.roomDataSet.Room);
            // TODO: This line of code loads data into the 'roomDataSet.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.roomDataSet.Room);
            loginController = new LoginViewController(this);
            loginModelController = new LoginModelController(this);
            employeeController = new EmployeeViewController();
            employeeModelController = new EmployeeModelController();
            roomController = new RoomViewController(this);
            roomModelController = new RoomModelController(this);
            customerController = new CustomerViewController(this);
            customerModelController = new CustomerModelController(this);
            errLogin = new ErrorProvider();
    }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (LoginModelController.login(txtUsername, txtPassword.Text))
            {
                loginController.onLogin(txtUsername.Text);
                employeeController.onLogin(txtUsername.Text);
                roomController.onLogin(txtUsername.Text);
                customerController.onLogin(txtUsername.Text);
                errLogin.SetError(btnLogin, null);
            }
            else
            {
                errLogin.SetError(btnLogin, "Invalid login credential(s)");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (loginModelController.logout())
            {
                loginController.onLogout();
                employeeController.onLogout();
                roomController.onLongout();
                customerController.onLogout();
            }
        }

        private void roomBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.roomBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.roomDataSet);

        }

        private void btnManageEmployees_Click(object sender, EventArgs e)
        {
            employeeController.showEmployeeManagerDialog();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void btnManagerCustomers_Click(object sender, EventArgs e)
        {
            customerController.showCustomerManagerDialog();

        }
    }
}
