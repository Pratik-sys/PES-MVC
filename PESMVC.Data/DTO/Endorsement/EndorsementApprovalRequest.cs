using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PESMVC.Data.DTO.Endorsement
{
    public class EndorsementApprovalRequest
    {
        [Required]
        public string endorsementId { get; set; }
        [Required]
        public string policyNumber { get; set; }
        [Required]
        public string Flag { get; set; }
    }
}
