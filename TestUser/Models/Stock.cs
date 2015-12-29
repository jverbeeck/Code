using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestUser.Models
{
    public class Stock
    {
        public int ProductID { get; set; }
        public string ProductType { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }


    }
}