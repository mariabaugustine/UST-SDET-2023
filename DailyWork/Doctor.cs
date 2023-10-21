using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyWork
{
    internal class Doctor:/*Class must come before inerface*/IDoctor,IAppointment
    {
        public int Did { get; set; }
        public string? DName { get; set; }

        public void AddNewDoctor()
        {
            Did = 1234;
            DName = "AAA";
        }

        public void ModifyDoctor()
        {
            Did = 987;
            DName = "ZZZ";
        }
        public void DisplayDoctorDetails()
        {
            Console.WriteLine("Did:{0}\t Name:{1}",Did,DName);
        }

        public void BookApp(int did, string pname)
        {
            Console.WriteLine("Appointment Booked for {0} with Doctor {1}",pname,did);
        }

        public void DelApp(int did, string pname)
        {
            Console.WriteLine("Appointment Deleted for {0} with Doctor{1}",pname,did);
        }
    }
}
