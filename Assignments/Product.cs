using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Product
    {
        private string  productName;
        private double price;
        private double quantity;

        public Product(string productName, double price, double quantity)
        {
            this.ProductName = productName;
            this.Price = price;
            this.Quantity = quantity;
        }

        public string ProductName { get => productName; set => productName = value; }
        public double Price { get => price; set => price = value; }
        public double Quantity { get => quantity; set => quantity = value; }
        public double SetPrice(double newPrice)
        {
            this.Price = newPrice;
            return Price;
        }
        public double ProductValue()
        {
            double totalValue = price * quantity;
            return totalValue;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("product name:" + ProductName);
            Console.WriteLine("price:" + price);
            Console.WriteLine("quantity:" + quantity);
        }
    }
}
