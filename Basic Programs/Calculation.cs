using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class Calculation
    {
        double num1, num2, ans;
        public double add(int num1,int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
            ans=num1 + num2;
            return ans;
           
        }
    }
}
