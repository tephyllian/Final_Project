using Final_Project.CustomerDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Final_Project
{
   public  class CustomerModelController: ModelController
    {
        private CustomerTableAdapter customerTableAdapter;

        public CustomerModelController(MainForm mainForm)
        {
            this.mainForm = mainForm;
            customerTableAdapter = new CustomerTableAdapter();
        }
        public List<String> getCustomerNames(String filter)
        {
            List<String> names = new List<String>();
            if(filter.Length > 0)
            {
                CustomerDataSet.CustomerDataTable table = customerTableAdapter.GetCustomerByName("%" + filter + "%");
                foreach(CustomerDataSet.CustomerRow row in table.Rows)
                {
                    names.Add(row.Name);
                }
            }
            else
            {
                CustomerDataSet.CustomerDataTable table = customerTableAdapter.GetData();
                foreach(CustomerDataSet.CustomerRow row in table.Rows)
                {
                    names.Add(row.Name);
                }
            }
            return names;
        }

        public CustomerDataSet.CustomerRow getCustomerByName(String name)
        {
            CustomerDataSet.CustomerDataTable table = customerTableAdapter.GetCustomerByName(name);
            if(table.Rows.Count == 1)
            {
                return table[0];
            }
            return null;
        }

        public List<String> getCustomerWithBalance(String filter)
        {
            filter = filter.ToLower();
            List<String> customers = new List<String>();
            CustomerDataSet.CustomerDataTable table = customerTableAdapter.GetWithOutstandingBalance();
            foreach (CustomerDataSet.CustomerRow row in table.Rows)
            {
             if(filter.Length == 0)
                {
                    customers.Add(row.Name);
                }
             else
                {
                    if (row.Name.ToLower().Contains(filter))
                    {
                        customers.Add(row.Name);
                    }
                }
            }
            return customers;
        }
    }
}
