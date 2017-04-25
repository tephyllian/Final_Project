using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_Project.HotelDataSetTableAdapters;

namespace Final_Project.ModelControllers {
    public class LoginModelController : ModelController {

        private LoginsTableAdapter loginTableAdapter;
        private Boolean loggedIn;
        private String currentUsername;

        public LoginModelController(MainForm mainForm) {
            this.mainForm = mainForm;
            loginTableAdapter = new LoginsTableAdapter();
            loggedIn = false;
            currentUsername = String.Empty;
        }

        public Boolean login(String username, String password) {
            HotelDataSet.LoginsDataTable results = loginTableAdapter.GetRowByUsername(username);
            if (results.Count == 1) {
                if (results[0].Username == username && results[0].Password == password) {
                    currentUsername = username;
                    loggedIn = true;
                    return true;
                }
            }
            return false;
        }

        public Boolean logout() {
            if (loggedIn) {
                loggedIn = false;
                currentUsername = String.Empty;
                return true;
            }
            return false;
        }

        public String getCurrentUsername() {
            return currentUsername;
        }

        public Boolean getLoginStatus() {
            return loggedIn;
        }
    }
}
