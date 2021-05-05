using PESMVC.API.Interface;
using PESMVC.Data.DTO.Customer;
using PESMVC.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;

namespace PESMVC.API.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly PES_TestEntities _dbContext;
        public CustomerService(PES_TestEntities dbContext)
        {
            _dbContext = dbContext;
        }

        public string CreateCustomer(CreateCustomerRequest createCustomerRequest)
        {
            ObjectParameter customerId = new ObjectParameter("custId", typeof(string));
            string value = null;
            try
            {
                var customer = new Customer
                {
                    customerName= createCustomerRequest.customerName,
                    customerAddress= createCustomerRequest.customerAddress,
                    customerTelephone = createCustomerRequest.customerTelephone,
                    customerGender = createCustomerRequest.customerGender,
                    customerDOB = createCustomerRequest.customerDOB,
                    customerSmoker = createCustomerRequest.customerSmoker,
                    customerHobbies = createCustomerRequest.customerHobbies
                };
                value = _dbContext.createCustomer(customer.customerName,customer.customerAddress, customer.customerTelephone, customer.customerGender, customer.customerDOB, customer.customerSmoker, customer.customerHobbies, customerId).ToList().ToString();
                
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return value;
        }

        public bool DeleteCustomer(string id)
        {
            bool flag = false;
            try
            {
                _dbContext.deleteCustomer(id);
                flag = true;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return flag;
        }

        public List<GetCustomerResponse> GetAllCustomer()
        {
            List<GetCustomerResponse> result = new List<GetCustomerResponse>();
            GetCustomerResponse customer = null;
            try
            {
                var customers = _dbContext.getAllCustomers();
                foreach (var c in customers)
                {
                    customer = new GetCustomerResponse();
                    customer.customerId = c.customerId;
                    customer.customerName = c.customerName;
                    customer.customerAddress = c.customerAddress;
                    customer.customerTelephone = c.customerTelephone;
                    customer.customerGender = c.customerGender;
                    customer.customerDOB = c.customerDOB;
                    customer.customerSmoker = c.customerSmoker;
                    customer.customerHobbies = c.customerHobbies;
                    result.Add(customer);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        public GetCustomerResponse GetCustomerById(string id)
        {
            GetCustomerResponse result = new GetCustomerResponse();
            try
            {
                var customers = _dbContext.getCustomerById(id);
                foreach (var c in customers)
                {
                    result.customerId = c.customerId;
                    result.customerName = c.customerName;
                    result.customerAddress = c.customerAddress;
                    result.customerTelephone = c.customerTelephone;
                    result.customerGender = c.customerGender;
                    result.customerDOB = c.customerDOB;
                    result.customerSmoker = c.customerSmoker;
                    result.customerHobbies = c.customerHobbies;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        public GetCustomerResponse GetCustomerByNameAndDobRequest(string name, DateTime DOB)
        {
            GetCustomerResponse result = new GetCustomerResponse();
            try
            {
                var customers = _dbContext.getCustomerByNameAndDob(name, DOB);
                foreach (var c in customers)
                {
                    result.customerId = c.customerId;
                    result.customerName = c.customerName;
                    result.customerAddress = c.customerAddress;
                    result.customerTelephone = c.customerTelephone;
                    result.customerGender = c.customerGender;
                    result.customerDOB = c.customerDOB;
                    result.customerSmoker = c.customerSmoker;
                    result.customerHobbies = c.customerHobbies;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }
    }
}