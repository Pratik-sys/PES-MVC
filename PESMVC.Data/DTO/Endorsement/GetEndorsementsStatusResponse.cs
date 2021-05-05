using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PESMVC.Data.DTO.Endorsement
{
    public class GetEndorsementsStatusResponse
    {

        public int Id { get; set; }

        public string endorsementId { get; set; }

        public string policyNumber { get; set; }

        public string endorsementStatus { get; set; }
    }
}
