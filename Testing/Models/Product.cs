
using System;
using System.Collections.Generic;
namespace Testing.Models
{
    public class Product
    {
        public Product()
        {
            // default constructor
        }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double CategoryID { get; set; }
        public int OnSale { get; set; }
        public int StockLevel { get; set; }

        public IEnumerable<Category> Categories { get; set; }


    }
}
