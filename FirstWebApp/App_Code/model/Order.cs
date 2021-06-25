using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DemoDataAccess
{
    class Order
    {
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public string EmployeeName { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }

        public Order(int orderID, string customerName, string employeeName, DateTime orderDate, DateTime requiredDate, DateTime shippedDate)
        {
            OrderID = orderID;
            CustomerName = customerName;
            EmployeeName = employeeName;
            OrderDate = orderDate;
            RequiredDate = requiredDate;
            ShippedDate = shippedDate;
        }

        public static int DeleteOrder(int OrderID)
        {
            return DAO.DeleteOrder(OrderID);
        }
    }

    class OrderList
    {
        public static List<Order> GetOrders(string CustomerID, int EmployeeID, DateTime FromDate, DateTime ToDate, Boolean LateOrder)
        {
            DataTable dt = DAO.GetOrders(CustomerID, EmployeeID, FromDate, ToDate, LateOrder);
            List<Order> orders = new List<Order>();
            foreach(DataRow dr in dt.Rows)
            {
                try  //chua chinh xac, can viet lai ky hon - sinh vien lam
                {
                    Order o = new Order(
                    Convert.ToInt32(dr["OrderID"]),
                    dr["CompanyName"].ToString(),
                    dr["EmployeeName"].ToString(),
                    Convert.ToDateTime(dr["OrderDate"]),
                    Convert.ToDateTime(dr["RequiredDate"]),
                    Convert.ToDateTime(dr["ShippedDate"])
                    );
                    orders.Add(o);
                }
                catch
                { }
            }
            return orders;
        }
    }
}
