using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class NonTeachingStaffDetails:StaffDetails
    {
        public string? Responsibilities {  get; set; }
        public int Experience {  get; set; }

        public void DisplayNTeachingStaffDetails()
        {
            Console.WriteLine("Responsibilities:{0}\n,Experience:{1}",Responsibilities,Experience);
        }
    }
}
