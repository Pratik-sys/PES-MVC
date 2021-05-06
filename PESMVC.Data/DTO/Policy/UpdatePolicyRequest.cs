using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PESMVC.Data.DTO.Policy
{
    public class UpdatePolicyRequest
    {
        [Required]
        [RegularExpression("^[A-Z0-9]*$", ErrorMessage = "Enter Valid Id")]
        public string customerId { get; set; }

        [Required]
        [RegularExpression("^[A-Z0-9]*$", ErrorMessage = "Enter Valid Id")]
        public string policyNumber { get; set; }

        [Required]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Nominee cannot be Empty")]
        public string policyNominee { get; set; }

        [Required(ErrorMessage = "Releation cannot be Empty")]
        public string policyNomineeRelation { get; set; }

        [Required(ErrorMessage = "Premium Payment cannot be empty")]
        public string policyPremiumPaymentFrequency { get; set; }

        [Required]
        [RegularExpression(@"((?:[^/]*/)*)(.*)", ErrorMessage = "Filepath is invalid")]
        public string filePath { get; set; }

        [Required(ErrorMessage = "Please Enter the Address")]
        public string customerAddress { get; set; }

        [Required(ErrorMessage = "Please Enter the Telephone")]
        [MaxLength(10, ErrorMessage = "Invalid Telephone Number")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Number should be of 10 ")]
        public string customerTelephone { get; set; }

        [Required]
        public bool customerSmoker { get; set; }
    }
}
