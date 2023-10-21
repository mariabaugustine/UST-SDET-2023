using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class Order
    {
        public string[] books {  get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalCost { get; set; }
    }
}
