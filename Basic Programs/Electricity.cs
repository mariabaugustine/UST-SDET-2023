using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class Electricity
    {
        int consumernumber,previousreading,currentreading;
        string consumername;
       //public Electricity()
       // {
       //     consumernumber = 12345;
       //     previousreading =9000;
       //     currentreading = 9300;
       //     consumername = "abcd";
       // }

        public Electricity(int consumernumber, int previousreading, int currentreading, string consumername)
        {
            this.consumernumber = consumernumber;
            this.previousreading = previousreading;
            this.currentreading = currentreading;
            this.consumername = consumername;
        }

        public double CalculateBill()
        {
            double billAmount = 0;
            int reading = currentreading - previousreading;
            if(reading <= 0)
            {
                billAmount = reading * 1;
            }
            else if(reading <= 201 && reading>=101)
            {
                billAmount = (100*2)+((reading-100)*2.5);
            }
            else if(reading<=401 && reading>=201)
            {
                billAmount = (100 * 2) + (100 * 2.5) + ((reading - 200) * 3.5);
            }
            else
            {
                billAmount = (100 * 2) + (100 * 2.5) + (200 * 3.5) + ((reading - 400) * 4);
            }
            return billAmount;
        }
       
    }
}
