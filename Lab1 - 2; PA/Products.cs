using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1___2__PA
{
    internal class Products
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public Products(string name, string id, double price, int stock)
        {
            Name = name;
            ID = id;
            Price = price;
            Stock = stock;
        }
    }
}
