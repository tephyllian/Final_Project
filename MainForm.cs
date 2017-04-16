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

       
    }
}
