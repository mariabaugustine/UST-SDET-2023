using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyWork
{
    internal class TeachingStaffDetails:StaffDetails
    {
        public string? Specialization { get; set; }
        public int? Sem { get; set; }

        public void DisplayTeachingStaffDetails()
        {
            Console.WriteLine("Specialization:{0}\n,Semester:{1}", Specialization, Sem);
        }
    }
}
