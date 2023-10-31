using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class GProduct<T>
    {
        public GProduct(int productId, string name, double price, double quantityInStock)
        {
            ProductId = productId;
            Name = name;
            Price = price;
            QuantityInStock = quantityInStock;
        }

        public int ProductId {  get; set; }
        public string Name { get; set; }

        public double Price {  get; set; }

        public double QuantityInStock {  get; set; }
    }
}
