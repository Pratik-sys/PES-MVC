using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PESMVC.Data.DTO.Policy
{
    public class ApplyForPolicyRequest
    {
        [Required]
        [RegularExpression("^[A-Z0-9]*$", ErrorMessage = "Enter Valid Id")]
        public string customerId { get; set; }

        [Required]
        [MaxLength(7)]
        [RegularExpression("^[A-Z0-9]*$", ErrorMessage = "Product Id cannot be empty or contain special characters")]
        public string productId { get; set; }

        [Required]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Nominee cannot be Empty")]
        public string policyNominee { get; set; }

        [Required(ErrorMessage ="Releation cannot be Empty")]
        public string policyNomineeRelation { get; set; }

        [Required(ErrorMessage = "Premium Payment cannot be empty")]
        public string policyPremiumPaymentFrequency { get; set; }
            
        [Required]
        [RegularExpression(@"((?:[^/]*/)*)(.*)", ErrorMessage = "Filepath is invalid")]
        public string filePath { get; set; }

    }
}
