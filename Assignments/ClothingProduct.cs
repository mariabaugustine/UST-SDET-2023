﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class ClothingProduct:Product
    {
        public ClothingProduct(string productName, double price, double quantity,string size):base(productName,price,quantity)
        {
            Size = size;
        }

        public string Size { get; set; }
        public string DisplaySize()
        {
            return Size;
        }

    }
}
