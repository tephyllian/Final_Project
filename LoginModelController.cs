using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class LoginModelController: ModelController
    {
        private LoginsDataSetTableAdapters.LoginsTableAdapter loginTableAdapter;
        private Boolean loggedIn;
        private String currentUsername;

        public LoginModelController(MainForm mainForm)
        {
            this.mainForm = mainForm;
            loginTableAdapter = new LoginsDataSetTableAdapters.LoginsTableAdapter();
            loggedIn = false;
            currentUsername = String.Empty;
        }

        public Boolean login(String username, String password)
        {
            LoginsDataSet.LoginsDataTable result = loginTableAdapter.GetData();
            if(result.Count == 1)
            {
            if(results.Count[0].Username == username && results[0].Password == password)
               
                {
                    currentUsername = username;
                    loggedIn = true;
                    return true;
                }
            }
            return false;
        }

        public Boolean logout()
        {
            if (loggedIn)
            {
                loggedIn = false;
                currentUsername = String.Empty;
                return true;
            }
            return false;
        }

        public String getCurrentUsername()
        {
            return currentUsername;
        }

        public Boolean getLoginStatus()
        {
            return loggedIn;
        }
    }
}
