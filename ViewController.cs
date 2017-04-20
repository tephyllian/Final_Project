using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.ViewController
{
    public abstract class ViewController
    {
        protected MainForm mainForm;
        public abstract void onLogin(String username);
        public abstract void onLogout();
        public abstract void resetView();
    }
}
