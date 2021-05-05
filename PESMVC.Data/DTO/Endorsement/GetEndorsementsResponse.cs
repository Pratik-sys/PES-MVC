using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PESMVC.Data.DTO.Endorsement
{
    public class GetEndorsementsResponse
    {
        public string endorsementId { get; set; }

        public string policyNumber { get; set; }

        public string FieldChanges { get; set; }

        public string endorsementStatus { get; set; }
    }
}
