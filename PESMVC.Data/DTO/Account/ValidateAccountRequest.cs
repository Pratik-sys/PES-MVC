using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PESMVC.Data.DTO.Account
{
    public class ValidateAccountRequest
    {
        [Required]
        public string loginId { get; set; }
        
        [Required]
        public string pswd { get; set; }

        [Required]
        public string roleType { get; set; }
    }
}
