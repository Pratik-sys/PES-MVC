using PESMVC.Data.Models;
using PESMVC.Data.DTO.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PESMVC.API.Interface
{
    public interface ICustomerService
    {
        bool CreateCustomer(CreateCustomerRequest createCustomerRequest);

        bool DeleteCustomer(string id);

        IQueryable GetAllCustomer(GetAllCustomersResponse getAllCustomersResponse);

        Customer SerarchCustomerById(string id, SearchCustomerByIdResponse searchCustomerByIdRequest);

        Customer SearchCustomerByNameAndDobRequest(string name, DateTime DOB, SearchCustomerByNameAndDobResponse searchCustomerByNameAndDob);

    }
}
