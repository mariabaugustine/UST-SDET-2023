using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class College
    {
        public string? CollegeName { get; set; }
        public void DisplayCollegeName()
        {
            Console.WriteLine("College Name:"+CollegeName);
        }
    }
}
