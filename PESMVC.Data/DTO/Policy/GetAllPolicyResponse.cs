using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PESMVC.Data.DTO.Policy
{
    public class GetAllPolicyResponse
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string policyNumber { get; set; }
        [Required]
        public string customerId { get; set; }
        [Required]
        public string productId { get; set; }
        [Required]
        public string policyNominee { get; set; }
        [Required]
        public string policyNomineeRelation { get; set; }
        [Required]
        public string policyPremiumPaymentFrequency { get; set; }
        [Required]
        public string filePath { get; set; }
    }
}
