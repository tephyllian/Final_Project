using Final_Project.ModelControllers;
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

namespace Final_Project {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private LoginViewController loginController;
        private LoginModelController loginModelController;
        private EmployeeViewController employeeController;
        private EmployeeModelController employeeModelController;
        private RoomViewController roomController;
        private RoomModelController roomModelController;
        private CustomerViewController customerController;
        private CustomerModelController customerModelController;

        private ErrorProvider errLogin;

        #region Controller Getters
        public ModelController getModelController(Type viewType) {
            if (viewType == typeof(LoginViewController)) {
                return loginModelController;
            }
            if (viewType == typeof(EmployeeViewController)) {
                return employeeModelController;
            }
            if (viewType == typeof(RoomViewController)) {
                return roomModelController;
            }
            if (viewType == typeof(CustomerViewController)) {
                return customerModelController;
            }
            return null;
        }

        public ViewController getViewController(Type modelType) {
            if (modelType == typeof(LoginModelController)) {
                return loginController;
            }
            if (modelType == typeof(EmployeeModelController)) {
                return employeeController;
            }
            if (modelType == typeof(RoomModelController)) {
                return roomController;
            }
            if (modelType == typeof(CustomerModelController)) {
                return customerController;
            }
            return null;
        }
        #endregion

        private void MainForm_Load(object sender, EventArgs e) {
            loginController = new LoginViewController(this);
            loginModelController = new LoginModelController(this);
            employeeController = new EmployeeViewController(this);
            employeeModelController = new EmployeeModelController(this);
            roomController = new RoomViewController(this);
            roomModelController = new RoomModelController(this);
            customerController = new CustomerViewController(this);
            customerModelController = new CustomerModelController(this);
            errLogin = new ErrorProvider();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            if (loginModelController.login(txtUsername.Text, txtPassword.Text)) {
                loginController.onLogin(txtUsername.Text);
                employeeController.onLogin(txtUsername.Text);
                roomController.onLogin(txtUsername.Text);
                customerController.onLogin(txtUsername.Text);
                errLogin.SetError(btnLogin, null);
            } else {
                errLogin.SetError(btnLogin, "Invalid login credential(s)");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e) {
            if (loginModelController.logout()) {
                loginController.onLogout();
                employeeController.onLogout();
                roomController.onLogout();
                customerController.onLogout();
            }
        }

        private void btnManageEmployees_Click(object sender, EventArgs e){
            employeeController.showEmployeeManagerDialog();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e){
            e.Handled = true;
            if(e.KeyCode == Keys.Enter){
                btnLogin_Click(sender, e);
            }
        }

        private void btnManageCustomers_Click(object sender, EventArgs e){
            customerController.showCustomerManagerDialog();
        }
    }
}
