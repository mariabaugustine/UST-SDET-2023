using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyWork
{
    internal class BankExample
    {
        public BankExample(int custId, long accNo, string? custName, string? status)
        {
            CustId = custId;
            AccNo = accNo;
            CustName = custName;
            Status = status;
        }

        public int CustId{ get; set; }
        public long AccNo {  get; set; }

        public string? CustName { get; set;}

        public string? Status { get; set; }

        public void GetAccountDetails(int custid )
        {
           if(CustId== custid)
            {
                Console.WriteLine("Account Number:{0},\t Name:{1}\t Status{2}",AccNo,CustName,Status);
            }
           else
            {
                Console.WriteLine("{0} does not exist", custid);
            }
        }
        public void GetAccountDetails(string? custname)
        {
            if (CustName == custname)
            {
                Console.WriteLine("Account Number:{0}\t Name:{1}\t Status{2}", AccNo, CustName, Status);
            }
            else
            {
                Console.WriteLine("{0} does not exist",custname);
            }
        }
        public void GetAccountDetails(long accno)
        {
            if (AccNo == accno)
            {
                Console.WriteLine("Account Number:{0},\t Name:{1}\t Status:{2}", AccNo, CustName, Status);
            }
            else
            {
                Console.WriteLine("{0} does not exist", accno);
            }
        }
    }
}
