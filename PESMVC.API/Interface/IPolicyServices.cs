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

        List<GetPolicyResponse> GetAllPolicy();

        List<GetPolicyResponse> GetPolicyByCustomerId(string id);

        List<GetPolicyResponse> GetPolicyByCustomerNameAndDob(string name,DateTime DOB);

        GetPolicyResponse GetPolicyByPolicyNumber(string policyNum);

        GetPolicyResponse GetPolicyByCustomerIdAndPolicyNumber(string custId, string policyNum);

        bool UpdatePolicy(UpdatePolicyRequest updatePolicyRequest);

        ViewPolicyResponse ViewPolicy(string id);
    }
}
