using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal abstract class InsurancePolicy1
    {
        protected InsurancePolicy1(int policyId, string policyName, double premiumAmount)
        {
            PolicyId = policyId;
            PolicyName = policyName;
            PremiumAmount = premiumAmount;
        }

        public int PolicyId {  get; set; }
        public string PolicyName { get; set; }
        
        public double PremiumAmount {  get; set; }

        public abstract double CalculatePremium();
        

        
    }
}
