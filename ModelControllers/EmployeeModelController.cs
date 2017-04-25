using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_Project.HotelDataSetTableAdapters;


namespace Final_Project.ModelControllers {
    public class EmployeeModelController : ModelController {

        private StaffTableAdapter staffTableAdapter = null;

        public EmployeeModelController(MainForm mainForm) {
            this.mainForm = mainForm;
            staffTableAdapter = new StaffTableAdapter();
        }

        public List<String> getEmployeeNames()
        {
            List<String> names = new List<String>();
            HotelDataSet.StaffDataTable table = staffTableAdapter.GetData();
            foreach(HotelDataSet.StaffRow row in table){
                names.Add(row.Name);
            }
            return names;
        }

        public HotelDataSet.StaffRow getEmployeeByName(String name)
        {
            HotelDataSet.StaffDataTable table = staffTableAdapter.GetByName(name);
            if(table.Rows.Count == 1)
            {
                return table[0];
            }
            return null;
        }
    }
}
