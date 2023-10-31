using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Employees
    {
        public Employees(int e_id, string name, int performanceRating)
        {
            E_id = e_id;
            Name = name;
            PerformanceRating = performanceRating;
        }

        public int E_id {  get; set; }
        public string Name { get; set;}

        public int PerformanceRating {  get; set; }

        public static List<Employees>EmployeeList= new List<Employees>();
        public static void AddEmployee(Employees employee)
        { 
          var data=EmployeeList.Find(X=>X.E_id == employee.E_id);
            if(data != null ) 
            {
                Console.WriteLine("Employee id already exist");
            }
            else
            {
                EmployeeList.Add(employee);
            }
           
        }
        public static decimal PerformanceBasedBonus(Employees employees1)
        {
           
            if(employees1.PerformanceRating>=4)
            {
                var bonus = 5000;
                return bonus;
            }
            else if( employees1.PerformanceRating>=2)
            {
                var bonus = 2500;
                return bonus;
            }
            else
            {
                var bonus = 1000;
              return bonus;
            }
        }
        public static decimal DepartmentBonus(Employees employees1) 
        {
            if (employees1.PerformanceRating >= 4)
            {
                var bonus = 5000*4;
                return bonus;
            }
            else if (employees1.PerformanceRating >= 2)
            {
                var bonus = 2500*3;
                return bonus;
            }
            else
            {
                var bonus = 1000*2;
                return bonus;
            }
        }

    }
}
