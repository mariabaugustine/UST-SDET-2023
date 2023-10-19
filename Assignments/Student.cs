﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Student
    {
        public string fullname;
        double mark1, mark2, mark3;
        

        public Student(string fullname,double mark1, double mark2, double mark3)
        {
            this.fullname = fullname;
            this.mark1 = mark1;
            this.mark2 = mark2;
            this.mark3 = mark3;
        }
        public double TotalMark()
        {
            double total = mark1 + mark2 + mark3;
            return total;
        }
        
        public double CalculateAverage()
        {
            double total =TotalMark();
            double average = total / 3;
            return average;
        }
        public char CalculateGrade()
        {
            double average = CalculateAverage();
            if (average > 89)
                return 'A';
            else if (average > 79 && average < 90)
                return 'B';
            else if (average > 69 && average < 80)
                return 'C';
            else if ((average > 59 && average < 70))
                return 'D';
            else if ((average > 49 && average < 60))
                return 'E';
            else
                return 'F';
            


        }
    }
}
