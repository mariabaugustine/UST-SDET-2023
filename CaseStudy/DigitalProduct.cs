using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class DigitalProduct:Product,IOrderable
    {
        public double Weight { get; set; }
        public double dimension { get; set; }

        public void DeleveringProduct(Customers customer)
        {
            throw new NotImplementedException();
        }

        public void PlacingOrder(Customers customer, double quantity)
        {
            throw new NotImplementedException();
        }

        public void ProceesingPayment()
        {
            throw new NotImplementedException();
        }
    }
}
