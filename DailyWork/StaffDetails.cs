using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyWork
{
    internal class StaffDetails:College
    {
        public int Staffid { get; set; }
        public string? Staffname { get; set; }
        public string? Dept { get; set; }

        public void DisplayStaffDetails()
        {
            Console.WriteLine("Id:{0}\nName:{1}\nDepartmrnt:{2}", Staffid, Staffname, Dept);
        }
    }
}
