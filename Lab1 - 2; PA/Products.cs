using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
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
        static string CreateID(ref int QuantityID)
        {
            QuantityID += 2;
            string IDLetter = "A" + QuantityID;
            return IDLetter;
        }
        public static void AddProduct(ref int QuantityID, ref List<Products> productList)
        {
            Console.Clear();
            Console.WriteLine("Add Products");
            Console.WriteLine("\nWhat is the Name of the Product?");
            string nameProduct = Console.ReadLine();
            Console.WriteLine("\nWhat is the Price of the Product?");
            double priceProduct = double.Parse(Console.ReadLine());
            Console.WriteLine("\nHow Much Shock Do We Have?");
            int stockProduct = int.Parse(Console.ReadLine());
            string newIDProduct = CreateID(ref QuantityID);
            Products NewProduct = new Products(newIDProduct, nameProduct, priceProduct, stockProduct);
            productList.Add(NewProduct);
            Console.WriteLine("\nYou Add A New Product!");
            Console.ReadKey();
        }
        public static void ConsultInformation(ref int idPosition, ref List<Products> productList)
        {
            Console.Clear();
            Console.WriteLine("Consult Information");
            Console.WriteLine("\nEnter the Product ID");
            string showIDInfo = Console.ReadLine();
            Products infoIDShow = productList.Find(p => p.ID == showIDInfo);
            if (infoIDShow != null)
            {
                Console.WriteLine("\nThe Product Exists");
                foreach (Products product in productList)
                {
                    if (product.ID == showIDInfo)
                    {
                        Console.WriteLine($"\n ID: {product.ID} | Name: {product.Name} | Price: Q.{Math.Round(product.Price, 2)} | Stock: {product.Stock} Units");
                        Console.ReadKey();
                        break;
                    }
                    idPosition++;
                }
            }
            else
            {
                Console.WriteLine("\nThe Product Doesn't Exist");
                Console.ReadKey();
            }
        }
        public Products(string id, string name, double price, int stock)
        {
            ID = id;
            Name = name;
            Price = price;
            Stock = stock;
        }
    }
}
