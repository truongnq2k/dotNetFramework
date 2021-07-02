using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace PETrialWinforms.DAL
{
    class ProductDAO
    {
        public static DataTable GetAllProduct()
        {
            string sql = @"SELECT Products.ProductID, Products.ProductName, Suppliers.CompanyName, Categories.CategoryName, Products.QuantityPerUnit, Products.UnitPrice, Products.UnitsInStock, Products.UnitsOnOrder, Products.ReorderLevel, Products.Discontinued FROM Categories INNER JOIN Products ON Categories.CategoryID = Products.CategoryID INNER JOIN Suppliers ON Products.SupplierID = Suppliers.SupplierID";
            return DAO.GetDataTable(sql);
        }
    }
}
