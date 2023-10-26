using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Customer
    {
        public int CustomerId {  get; set; }
        public string? CustomerName { get; set; }

        public long PhoneNumber {  get; set; }

        public double Balance { get; set; }

        public static List<Customer> Customers = new List<Customer>()
       {
           new Customer() {CustomerId=1,CustomerName="AAA",PhoneNumber=9496739548,Balance=12345},
           new Customer() {CustomerId=2,CustomerName="BBB",PhoneNumber=9497859448,Balance=45678},
           new Customer() {CustomerId=3,CustomerName="CCC",PhoneNumber=8281322673,Balance=987654}
       };
        public void SearchDetails(long phonenumber)
        {
            var data=Customers.Find(x=>x.PhoneNumber==phonenumber);
           if(data!=null)
            {
                    Console.WriteLine("Name:"+data.CustomerName);
                    Console.WriteLine("Balance:"+data.Balance); 
                
            }
            else
            {
                Console.WriteLine("No record Found ");
            }
        }
        public void DisplayDetails()
        {
            foreach(var customer in Customers) 
            {
                Console.WriteLine("Customer Id:"+customer.CustomerId+"\n"+"Name:"+customer.CustomerName+"\n"+"Phone Number:"+customer.PhoneNumber+"\n"+"Balance:"+customer.Balance);
                Console.WriteLine("\n");
            }
        }


    }
}
