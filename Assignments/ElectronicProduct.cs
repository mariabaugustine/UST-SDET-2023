using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class ElectronicProduct:Product
    {
        public ElectronicProduct(string productName, double price, double quantity,int warrantyPeriod):base(productName,price,quantity)
        {
            WarrantyPeriod = warrantyPeriod;
        }

        public int WarrantyPeriod {  get; set; }
        public int  DisplayWarrantyPeriod()
        {
            return WarrantyPeriod;
        }
    }
}
