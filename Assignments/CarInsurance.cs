using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class CarInsurance : InsurancePolicy1
    {
        public CarInsurance(int policyId, string policyName, double premiumAmount,string? CarType) : base(policyId, policyName, premiumAmount)
        {
        }

        public string? CarType { get; set; }

        public override double CalculatePremium()
        {
            if(CarType =="electrical") 
            {
                return PremiumAmount * 0.2 + PremiumAmount;
            }
            else if(CarType =="petrol")
            {
                return PremiumAmount * 0.3 + PremiumAmount;
            }
            else if(CarType=="diesel")
            {
                return PremiumAmount * 0.4 + PremiumAmount;
            }
            else
            {
                return PremiumAmount * 0.5 + PremiumAmount;
            }
        }
    }
}
