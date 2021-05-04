using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PESMVC.Data.Models.DTO.Policy
{
    public class SearchByPolicyNumberRequest
    {
        [Required]
        public string policyNumber { get; set; }
    }
}
