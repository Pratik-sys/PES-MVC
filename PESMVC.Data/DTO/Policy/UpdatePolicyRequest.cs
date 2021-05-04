using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PESMVC.Data.Models.DTO.Policy
{
    public class UpdatePolicyRequest
    {
        [Required]
        public string customerId { get; set; }
        [Required]
        public string policyNumber { get; set; }
        [Required]
        public string policyNominee { get; set; }
        [Required]
        public string policyNomineeRelation { get; set; }
        [Required]
        public string policyPremiumPaymentFrequency { get; set; }
        [Required]
        public string filePath { get; set; }
        [Required]
        public string customerAddress { get; set; }
        [Required]
        public string customerTelephone { get; set; }
        [Required]
        public bool customerSmoker { get; set; }
    }
}
