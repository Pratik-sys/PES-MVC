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
        string CreateCustomer(CreateCustomerRequest createCustomerRequest);

        bool DeleteCustomer(string id);

        List<GetCustomerResponse> GetAllCustomer();

        GetCustomerResponse GetCustomerById(string id);

        GetCustomerResponse GetCustomerByNameAndDobRequest(string name, DateTime DOB);
    }
}
