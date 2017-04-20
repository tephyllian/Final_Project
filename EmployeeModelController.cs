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
        private StaffTableAdapter staffTableAdapter = null;
        public EmployeeModelController(MainForm mainForm)
        {
            this.mainForm = mainForm;
            staffTableAdapter = new StaffTableAdapter();
        }

        public List<String> getEmployeeNames()
        {
            List<String> names = new List<String>();
            StaffDataSet.StaffDataTable table = staffTableAdapter.GetData();
            foreach(StaffDataSet.StaffRow row in table)
            {
                names.Add(row.Name);
            }
        }

        public StaffDataSet.StaffRow getEmployeessByNames(String name)
        {
            StaffDataSet.StaffDataTable table = staffTableAdapter.GetByName(name);
            if(table.Rows.Count == 1)
            {
                return table[0];
            }
            return null;
        }
    }
}
