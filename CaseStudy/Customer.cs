using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class Customer
    {
        public int CustomerId;
        public string? Name;
        public string? ContactDetails;

        public Customer(int customerId, string? name, string? contactDetails)
        {
            CustomerId = customerId;
            Name = name;
            ContactDetails = contactDetails;
        }
        
    }
}
