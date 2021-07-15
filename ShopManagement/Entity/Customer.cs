using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ShopManagement.Entity
{
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

    //class CustomerList
    //{
    //    public static List<Customer> GetAllCustomer()
    //    {
    //        List<Customer> customers = new List<Customer>();
    //        DataTable dt = DAL.CustomerDAO.GetAllCustomer();
    //        foreach (DataRow dr in dt.Rows)
    //        {
    //            Customer c = new Customer();
    //            //Convert.ToInt32(dr["CustomerID"]),
    //            //dr["ContactName"].ToString());
    //            c.ContactName = dr["ContactName"].ToString();
    //            c.CustomerID = Convert.ToInt32(dr["CustomerID"]);
    //            customers.Add(c);
    //        }
    //        return customers;
    //    }
    //}
}
