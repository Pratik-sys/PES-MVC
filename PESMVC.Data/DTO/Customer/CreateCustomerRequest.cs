using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PESMVC.Data.Models.DTO.Customer
{
    public class CreateCustomerRequest
    {
        [Required]
        public string customerName { get; set; }
        [Required]
        public string customerAddress { get; set; }
        [Required]
        public string customerTelephone { get; set; }
        [Required]
        public string customerGender { get; set; }
        [Required]
        public System.DateTime customerDOB { get; set; }
        [Required]
        public bool customerSmoker { get; set; }
        [Required]
        public string customerHobbies { get; set; }
    }
}
