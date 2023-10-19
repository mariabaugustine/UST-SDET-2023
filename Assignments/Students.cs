using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Students
    {
        private string name;
        private int[] marks;
        private char grade;
        private double total=0;

        public Students(string name, int[] marks)
        {
            this.Name = name;
            this.Marks = marks;
            
        }

        public string Name { get => name; set => name = value; }
        public int[] Marks { get => marks; set => marks = value; }
        public char Grade { get => grade; set => grade = value; }
        public double CalculateAverage()
        {
            
            foreach (var mark in Marks) 
            {
                total = total + mark;
            }
            var average = total / marks.Length;
            return average;
        }
        public char CalculateGrade()
        {
         double average = CalculateAverage();
            if (average > 90)
                return 'A';
            else if (average > 80)
                return 'B';
            else if (average > 70)
                return 'C';
            else if (average > 60)
                return 'D';
            else if (average > 50)
                return 'E';
            else
                return 'F';

        }
        public string GetMarkSummary()
        {
            double highest = marks.Max();
            double lowest= marks.Min();
            return $"{name} has  {marks.Length} marks.\n Highest Mark:{highest} ,Lowest Mark:{lowest}";
         }
    }
}
