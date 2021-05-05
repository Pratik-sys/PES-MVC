using PESMVC.API.Interface;
using PESMVC.Data.DTO.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PESMVC.API.Controllers
{
    public class CustomerController : ApiController
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost]
        public IHttpActionResult CreateCustomerApi([FromBody] CreateCustomerRequest createCustomerRequest)
        {
            string message = "failed";
            string result = null;
            result =_customerService.CreateCustomer(createCustomerRequest);
            if(result != null)
            {
                message = result;
            }
            return Ok(message);
        }

        [HttpDelete]
        public IHttpActionResult DeleteCustomerApi(string id)
        {
            string message = "Failed";
            if (id != null)
            {
                if (_customerService.DeleteCustomer(id))
                {
                    message = "Success";
                }
            }
            return Ok(message);
        }

        [HttpGet]
        public List<GetCustomerResponse> GetAllCustomersApi()
        {
            var result = new List<GetCustomerResponse>();
            try
            {
                result = _customerService.GetAllCustomer();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        [HttpGet]
        public GetCustomerResponse GetCustomerByIdApi(string id)
        {
            var result = new GetCustomerResponse();
            try
            {
                result = _customerService.GetCustomerById(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        [HttpGet]
        public GetCustomerResponse GetCustomerByNameAndDobApi(string name, DateTime DOB)
        {
            var result = new GetCustomerResponse();
            try
            {
                result = _customerService.GetCustomerByNameAndDobRequest(name,DOB);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

    }
}
