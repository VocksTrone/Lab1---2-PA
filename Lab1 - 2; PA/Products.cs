using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1___2__PA
{
    internal class Products
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public Products(string id, string name, double price, int stock)
        {
            ID = id;
            Name = name;
            Price = price;
            Stock = stock;
        }
    }
}
