using System;
using System.Collections.Generic;
using System.Text;

namespace CET1004_Week7
{
    internal class Product
    {
        string name;
        int quantity;
        public static List<Product> products = new List<Product>();

        Product()
        {
            name = "Default";
            quantity = 0;
        }

        Product(string name, int quantity)
        {
            this.name = name;
            this.quantity = quantity;  
        }



        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public static void AddProductToList(Product product)
        {
            products.Add(product);
        }

        public static void AddProductToList(string name, int quantity)
        {
            products.Add(new Product(name, quantity));
        }

        public static void DisplayProducts()
        {
            foreach (Product product in products)
            {
                Console.WriteLine($"Product: {product.Name}, Quantity: {product.Quantity}");
            }
        }

        public static int CumulativeQty()
        {
            int cumulativeQty = 0;
            foreach (Product product in products)
            {
                cumulativeQty += product.Quantity;
            }
            return cumulativeQty;
        }
    }
}
