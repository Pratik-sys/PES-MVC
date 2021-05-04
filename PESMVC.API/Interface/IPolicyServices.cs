using PESMVC.Data.DTO.Policy;
using PESMVC.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PESMVC.API.Interface
{
    public interface IPolicyServices
    {
        bool ApplyForPolicy(ApplyForPolicyRequest applyForPolicyRequest);

        bool GetAllPolicy(GetAllPolicyResponse getAllPolicyResponse);

        List<GetPolicyByCustomerIdResponse> GetPolicyByCustomerId(string id);

        List<GetPolicyByCustomerNameAndDobResponse> GetPolicyByCustomerNameAndDob(string name,DateTime DOB);

        GetPolicyByPolicyNumberResponse GetPolicyByPolicyNumber(string policyNum);

        GetPolicyByCustomerIdAndPolicyNumberResponse GetPolicyByCustomerIdAndPolicyNumber(string custId, string policyNum);

        bool UpdatePolicy(UpdatePolicyRequest updatePolicyRequest);

        ViewPolicyResponse ViewPolicy(string id);
    }
}
