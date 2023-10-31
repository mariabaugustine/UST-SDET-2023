using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Inventory<T>
    {
        List<GProduct<T>>products=new List<GProduct<T>>();
        public void AddProduct(GProduct<T> product)
        {
            products.Add(product);
        }
        public void UpdateProduct(int id,string?name,double price,double quantity)
        {
            
          GProduct<T> product = products.Find(X=>X.ProductId == id);
            if(product != null) 
            {
                product.Name = name;
                product.Price = price;
                product.QuantityInStock = quantity;
            }
            else
            {
                Console.WriteLine("No item found");
            }
        }
        public void DeleteProduct(int id)
        {
          GProduct<T>product=products.Find(X=>X.ProductId == id);
            if(product != null)
            {
             products.Remove(product);
            }
            else
            {
                Console.WriteLine("No record found");
            }
        }
        public GProduct<T> SearchProductById(int id)
        {
            return products.Find(x => x.ProductId == id);
        }
        public List<GProduct<T>>SearchByName(string?name)
        {
            return products.FindAll(x => x.Name == name);
        }
    }
}
