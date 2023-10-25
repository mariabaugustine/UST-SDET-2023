using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class InsurancePolicy
    {
        public InsurancePolicy(int policyId, string? policyName, double? premiumAmount)
        {
            PolicyId = policyId;
            PolicyName = policyName;
            PremiumAmount = premiumAmount;
        }

        public int PolicyId {  get; set; }
        public string ?PolicyName { get; set; }
         
        public double ? PremiumAmount {  get; set; }

        public double RenewPolicy(double newPremium)
        {
             PremiumAmount = newPremium;
            return (double)PremiumAmount;

        }
        public double RenewPolicy()
        {
            PremiumAmount = PremiumAmount * 0.1 + PremiumAmount;
            return (double)PremiumAmount;
        }
    }
}
