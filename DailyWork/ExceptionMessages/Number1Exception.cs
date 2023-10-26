using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyWork.ExceptionMessages
{
    internal class Number1Exception:Exception
    {
        public Number1Exception(string message):base(message) 
        { 
        }
    }
    internal class Number2Exception:Exception 
    { 
        public Number2Exception(string message):base(message) 
        {
        }
    }
}
