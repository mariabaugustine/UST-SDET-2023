using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyWork.ExceptionMessages
{
    internal class MyExceptions
    {
        /*public static   List<string> exceptionmessages = new List<string>()
           {
               "Dont give zero for Denominator",
               "Index is out of range",
               "Unknown"
           };*/
        public static Dictionary<int, string> exceptionmessage = new Dictionary<int, string>()
        {
            {1,"Dont give zero for denominator" },
            {2,"Index is out of range" },
            {3,"Unknown"},
            {4,"Age is less" },
            {5,"Age is high" }
        };


    }
}
