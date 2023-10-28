using CaseStudy.CustomException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class PhysicalProduct:Product,IOrderable
    { 
        public double Weight {  get; set; } 
        public double dimension {  get; set; }

        


        public void PlacingOrder(Customers customer, int quantity)
        {
            if (StockQuantity >= quantity)
            {
                StockQuantity -= quantity;
            }
            else
            {
                throw new OrderException(MyException.Errors[1]);
            }
        }

        public void DeleveringProduct(Customers customer)
        {
            throw new NotImplementedException();
        }

        public void ProceesingPayment()
        {
            throw new NotImplementedException();
        }
    }
}
