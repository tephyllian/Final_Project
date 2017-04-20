using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_Project.StaffDataSetTableAdapters;
namespace Final_Project.ModelControllers
{
   public class EmployeeModelController: ModelController
    {
        private StaffDataTableAdapters staffTableAdapter = null;
        public EmployeeModelController(MainForm mainForm)
        {
            this.mainForm = mainForm;
            staffTableAdapter = new StaffDataSetTableAdapters();
        }

        public List<String> getEmployeeNames()
        {
            List<String> names = new List<String>();

        }
    }
}
