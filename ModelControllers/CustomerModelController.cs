using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_Project.HotelDataSetTableAdapters;

namespace Final_Project.ModelControllers {
    public class CustomerModelController : ModelController {
        private CustomerTableAdapter customerTableAdapter;

        public CustomerModelController(MainForm mainForm) {
            this.mainForm = mainForm;
            customerTableAdapter = new CustomerTableAdapter();
        }

        public List<String> getCustomerNames(String filter) {
            List<String> names = new List<String>();
            if (filter.Length > 0) {
                HotelDataSet.CustomerDataTable table = customerTableAdapter.GetCustomerByName("%" + filter + "%");
                foreach (HotelDataSet.CustomerRow row in table.Rows) {
                    names.Add(row.Name);
                }
            } else {
                HotelDataSet.CustomerDataTable table = customerTableAdapter.GetData();
                foreach (HotelDataSet.CustomerRow row in table.Rows) {
                    names.Add(row.Name);
                }
            }
            return names;
        }

        public HotelDataSet.CustomerRow getCustomerByName(String name) {
            HotelDataSet.CustomerDataTable table = customerTableAdapter.GetCustomerByName(name);
            if (table.Rows.Count == 1) {
                return table[0];
            }
            return null;
        }

        public List<String> getCustomersWithBalance(String filter) {
            filter = filter.ToLower();
            List<String> customers = new List<String>();
            HotelDataSet.CustomerDataTable table = customerTableAdapter.GetWithOutstandingBalance();
            foreach (HotelDataSet.CustomerRow row in table.Rows) {
                if (filter.Length == 0) {
                    customers.Add(row.Name);
                } else {
                    if (row.Name.ToLower().Contains(filter)) {
                        customers.Add(row.Name);
                    }
                }
            }
            return customers;
        }


    }
}
