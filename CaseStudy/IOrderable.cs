﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal interface IOrderable
    {
        public void PlacingOrder(Customers customer,int quantity);
        public void ProceesingPayment();

        public void DeleveringProduct(Customers customer);


    }
}
