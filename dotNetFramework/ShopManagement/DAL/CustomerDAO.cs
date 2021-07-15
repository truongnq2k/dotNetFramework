using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ShopManagement.DAL
{
    class CustomerDAO
    {
        public static DataTable GetAllCustomer()
        {
            string sql = "SELECT CustomerID, ContactName FROM Customers";
            return DAO.GetDataTable(sql);
        }
    }

    class Customer
    {
        public int CustomerID { get; set; }
        public string ContactName { get; set; }

        public Customer(int customerID, string contactName)
        {
            CustomerID = customerID;
            ContactName = contactName;
        }
    }

    class ListCustomer
    {
        public List<Customer> GetCustomers()
        {
            List<Customer> listCustomer = new List<Customer>();

            var list = CustomerDAO.GetAllCustomer();

            foreach (DataTable dr in list.Rows)
            {
                Customer c = new Customer(Convert.ToInt32(dr["CustomerID"]), dr["ContactName"].)
            }

            return listCustomer;
        }



    }
}
