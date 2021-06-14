using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Database.model
{
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
