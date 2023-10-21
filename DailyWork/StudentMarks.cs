using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyWork
{
    internal class StudentMarks:StudentDetails
    {
        public StudentMarks(int mark1, int mark2, int mark3, int total, double average, int rollNo, string? studName, string? city) : base(rollNo, studName, city)
        {
            this.mark1 = mark1;
            this.mark2 = mark2;
            this.mark3 = mark3;
            this.total = total;
            this.average = average;
        }

        public int mark1 { get; set; }
        public int mark2 { get; set; }
        public int mark3 { get; set; }
        public int total { get; set; }
        public double average { get; set; }

        public int CalculateTotalMarks()
        {
            Total = mark1 + mark2 + mark3;
            return Total;
        }
        public double CalculateAverage()
        {
            int average = Total / 3;
            return average;
        }
    }
}
