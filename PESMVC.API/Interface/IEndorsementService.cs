using PESMVC.Data.DTO.Endorsement;
using PESMVC.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PESMVC.API.Interface
{
    public interface IEndorsementService
    {
        bool EndorsementApproval(EndorsementApprovalRequest endorsementApprovalRequest);

        List<GetEndorsementsResponse> GetAllEndorsements();

        List<GetEndorsementsStatusResponse> GetAllEndorsementStatus(string id);
    }
}
