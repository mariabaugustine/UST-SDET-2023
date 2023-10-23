using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Employee:Person,IDisplayInfo
    {
        private int e_Id;

        public Employee(string? firstName, string? lastName, int age,int e_Id) : base(firstName, lastName, age)
        {
            E_Id = e_Id;
        }

        public int E_Id { get => e_Id; set => e_Id = value; }

        public void DisplayInfo(int age)
        {
            if (age >= 18 && age <= 100)
           
                Console.WriteLine($"Employee Id:" + E_Id);
                Console.WriteLine($"Full Name:" + FirstName+LastName);
                Console.WriteLine($"Age:" + Age);

            }

        
    }
}
