using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyWork
{
    internal interface IAppointment
    {
        void BookApp(int did, string pname);
        void DelApp(int did, string pname);
    }
}
