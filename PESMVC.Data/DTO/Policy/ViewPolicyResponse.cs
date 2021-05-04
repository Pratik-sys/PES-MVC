using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PESMVC.Data.DTO.Policy
{
    public class ViewPolicyResponse
    {
        public string customerId { get; set; }
        public string customerName { get; set; }
        public string customerAddress { get; set; }
        public string customerTelephone { get; set; }
        public string customerGender { get; set; }
        public DateTime customerDOB { get; set; }
        public bool customerSmoker { get; set; }
        public string productId { get; set; }
        public string productName { get; set; }
        public string productLine { get; set; }
        public string policyNumber { get; set; }
        public string policyNominee { get; set; }
        public string policyNomineeRelation { get; set; }
        public string policyPremiumPaymentFrequency { get; set; }
        public string filePath { get; set; }
    }
}
