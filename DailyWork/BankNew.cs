using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyWork
{
    internal class BankNew : BankExample
    {
        public BankNew(int custId, long accNo, string? custName, string? status) : base(custId, accNo, custName, status)
        {
        }
        /*public new void WelcomeMessage()
        {
            Console.WriteLine("Welcome {0}",CustName);
        }*/
    }
}
