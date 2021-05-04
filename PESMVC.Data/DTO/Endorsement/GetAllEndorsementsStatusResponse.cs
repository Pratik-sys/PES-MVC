using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PESMVC.Data.Models.DTO.Endorsement
{
    class GetAllEndorsementsStatusResponse
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string endorsementId { get; set; }
        [Required]
        public string policyNumber { get; set; }
        [Required]
        public string endorsementStatus { get; set; }
    }
}
