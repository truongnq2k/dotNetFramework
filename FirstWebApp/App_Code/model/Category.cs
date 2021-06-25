using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DemoDataAccess
{
    class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public Category(int categoryID, string categoryName)
        {
            CategoryID = categoryID;
            CategoryName = categoryName;
        }

    }

    class CategoryList
    {
        public static List<Category> GetAllCategory()
        {
            List<Category> categories = new List<Category>();
            DataTable dt = DAO.GetAllCategories();
            foreach(DataRow dr in dt.Rows)
            {
                Category c = new Category(
                    Convert.ToInt32( dr["CategoryID"]),
                    dr["CategoryName"].ToString()
                    );
                categories.Add(c);
            }
            return categories;
        }
    }
}
