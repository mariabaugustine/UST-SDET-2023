using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.MyException
{
    internal class CustomException
    {
        public static Dictionary<int, string> exceptionmessage = new Dictionary<int, string>()
        {
            {1,"Age Should be between 0 and 120" },
            {2,"Patient name cannot be null" },
            {3,"Diagnosis cannot be null" }
           
        };
    }

    internal class MyExceptions : Exception
    {
        public MyExceptions(string message) : base(message)
        {
        }
    }
}
