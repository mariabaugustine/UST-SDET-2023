using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.CustomException
{
    internal class MyException
    {
        public static Dictionary<int, string> Errors { get; set; } = new Dictionary<int, string>()
        {
            {1,"Insufficient stock"},
            {2,"Order failed" },
            {3,"No Product Found" },
            {4,"Credit acrd details cannot be empty" }


        };
    }
    internal class OrderException:Exception
    {
        public OrderException(String message):base(message) 
        { 
        }
    }
}
