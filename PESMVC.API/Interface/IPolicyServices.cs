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

        Policy SearchByCustomerId(string id, SearchByCustomerIdResponse searchByCustomerIdResponse);

        Policy SearchByCustomerNameAndDob(string name,DateTime DOB, SearchByCustomerNameAndDobResponse searchByCustomerNameAndDob);
        
        Policy SearchByPolicyNumber(string policyNum, SearchByPolicyNumberResponse searchByCustomerIdRequest);

        Policy SearchPolicyByCustomerIdAndPolicyNumber(string custId, string policyNum, SearchPolicyByCustomerIdAndPolicyNumberResponse searchPolicyByCustomerIdAndPolicyNumber);

        bool UpdatePolicy(UpdatePolicyRequest updatePolicyRequest);

        IQueryable ViewPolicy(ViewPolicyResponse viewPolicyResponse);
    }
}
