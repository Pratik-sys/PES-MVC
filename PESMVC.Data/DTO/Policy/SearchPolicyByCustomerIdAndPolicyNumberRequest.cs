using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PESMVC.Data.Models.DTO.Policy
{
    public class SearchPolicyByCustomerIdAndPolicyNumberRequest
    {
        [Required]
        public string customerId { get; set; }
        [Required]
        public string policyNumber { get; set; }
    }
}
