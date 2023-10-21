using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyWork
{
    internal class College
    {
        public string? CollegeName { get; set; }
        public void DisplayCollegeName()
        {
            Console.WriteLine("College Name:" + CollegeName);
        }
    }
}
