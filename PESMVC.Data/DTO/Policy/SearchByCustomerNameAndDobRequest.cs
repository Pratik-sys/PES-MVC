using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PESMVC.Data.Models.DTO.Policy
{
    public class SearchByCustomerNameAndDobRequest
    {
        [Required]
        public string customerName { get; set; }
        [Required]
        public System.DateTime customerDOB { get; set; }
    }
}
