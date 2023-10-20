using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class DigitalProduct:ElectronicProduct
    {
        public DigitalProduct(string fileFormat, string productName, double price, double quantity, int warrantyPeriod):base(productName, price, quantity, warrantyPeriod)  
        {
            FileFormat = fileFormat;
        }

        public string FileFormat {  get; set; }
        public string DisplayFileFormat()
        {
          return FileFormat;
        }
    }
}
