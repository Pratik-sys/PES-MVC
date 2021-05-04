using PESMVC.Data.Models.DTO.Customer;
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
        bool DeleteCustomer(DeleteCustomerRequest deleteCustomerRequest);
        IQueryable GetAllCustomer(GetAllCustomersResponse getAllCustomersResponse);
        bool SerarchCustomerById(SearchCustomerByIdRequest searchCustomerByIdRequest);
        bool SearchCustomerByNameAndDobRequest(SearchCustomerByNameAndDobRequest searchCustomerByNameAndDob);

    }
}
