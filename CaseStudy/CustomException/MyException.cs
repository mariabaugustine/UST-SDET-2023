using System;
using System.Collections.Generic;
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
            {2,"Order failed" }


        };
    }
    internal class OrderException:Exception
    {
        public OrderException(String message):base(message) 
        { 
        }
    }
}
