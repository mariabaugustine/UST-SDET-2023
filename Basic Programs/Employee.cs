using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class Employee
    {
        private int emp_id;
        private string ? emp_name,department;
        private double basic_pay;
        private readonly int _bonus = 1000;
        public Employee(int emp_id, string emp_name, string department, double basic_pay)
        { //this-reference variable to the pointer
            Emp_id = emp_id;
            Emp_name = emp_name;
            Department = department;
            Basic_pay = basic_pay;
        }

        public int Emp_id { get => emp_id; set => emp_id = value; }
        public string? Emp_name { get => emp_name; set => emp_name = value; }
        public string? Department { get => department; set => department = value; }
        public double Basic_pay { get => basic_pay; set => basic_pay = value; }

        public int Bonus => _bonus;

        public double CalculateSalary()
        {
            double netSalary, grossSalary;
            double allowances = Basic_pay * 0.3 + Basic_pay * 0.2 + Basic_pay * 0.15;
            grossSalary = Basic_pay + allowances;
            double deduction = Basic_pay * 0.1;
            netSalary= grossSalary -deduction;
            return netSalary;

        }
    }
}
