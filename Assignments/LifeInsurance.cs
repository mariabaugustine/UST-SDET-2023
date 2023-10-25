using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class LifeInsurance : InsurancePolicy1
    {
        public LifeInsurance(int policyId, string policyName, double premiumAmount,int Age) : base(policyId, policyName, premiumAmount)
        {
        }
        public int Age {  get; set; }

        public override double CalculatePremium()
        {
           if(Age<=10)
            {
                return PremiumAmount * 0.1 + PremiumAmount;
            }
           else if(Age<=18)
            {
                return PremiumAmount * 0.2 + PremiumAmount;
            }
           else if(Age<=60)
            {
                return PremiumAmount * 0.3 + PremiumAmount;
            }
           else
            {
                return PremiumAmount * 0.4 + PremiumAmount;
            }
        }
    }
}
