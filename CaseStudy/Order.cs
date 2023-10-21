using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class Order
    {
        private string? date;
        private double total;

        public Order(string? date, double total)
        {
            this.date = date;
            this.total = total;
        }

        //public string[] books {  get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalCost { get; set; }
        public void OrderDetails()
        {
            Console.WriteLine($"Order date:"+date +"\n" +"Total price:"+total);
        }
    }
}
