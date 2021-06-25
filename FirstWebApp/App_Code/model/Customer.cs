using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DemoDataAccess
{
    class Customer
    {
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }

        public Customer(string CustomerID, string CustomerName)
        {
            this.CustomerID = CustomerID;
            this.CustomerName = CustomerName;
        }

    }

    class CustomerList
    {
        public static List<Customer> GetAllCustomer()
        {
            List<Customer> customers = new List<Customer>();
            DataTable dt = DAO.GetAllCustomer();
            foreach (DataRow dr in dt.Rows)
            {
                Customer c = new Customer(
                    dr["CustomerID"].ToString(),
                    dr["CompanyName"].ToString()
                    );
                customers.Add(c);
            }
            return customers;
        }

        public static List<Customer> GetAllCustomerWithItemAll()
        {
            List<Customer> customers = GetAllCustomer();
            customers.Insert(0, new Customer("All", "All Customer"));
            return customers;
        }
    }
}
