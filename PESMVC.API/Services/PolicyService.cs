using PESMVC.API.Interface;
using PESMVC.Data.DTO.Policy;
using PESMVC.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PESMVC.API.Services
{
    public class PolicyService: IPolicyServices
    {
        private readonly PES_TestEntities _dbContext;

        public PolicyService(PES_TestEntities dbContext)
        {
            _dbContext = dbContext;
        }

        public bool ApplyForPolicy(ApplyForPolicyRequest applyForPolicyRequest)
        {
            bool flag = false;
            try
            {
                var policyProduct = new Policy
                {
                    customerId = applyForPolicyRequest.customerId,
                    productId = applyForPolicyRequest.productId,
                    policyNominee = applyForPolicyRequest.policyNominee,
                    policyNomineeRelation = applyForPolicyRequest.policyNomineeRelation,
                    policyPremiumPaymentFrequency = applyForPolicyRequest.policyPremiumPaymentFrequency,
                    filePath = applyForPolicyRequest.filePath
                };

                _dbContext.createPolicy(policyProduct.customerId, policyProduct.productId, policyProduct.policyNominee, policyProduct.policyNomineeRelation, policyProduct.policyPremiumPaymentFrequency, policyProduct.filePath);

                flag = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return flag;
        }

        public List<GetPolicyResponse> GetAllPolicy()
        {
            List<GetPolicyResponse> result = new List<GetPolicyResponse>();
            GetPolicyResponse policy = null;
            try
            {
                var policies = _dbContext.getAllPolicy();
                foreach (var p in policies)
                {
                    policy = new GetPolicyResponse();
                    policy.Id = p.Id;
                    policy.policyNumber = p.policyNumber;
                    policy.customerId = p.customerId;
                    policy.productId = p.productId;
                    policy.policyNominee = p.policyNominee;
                    policy.policyNomineeRelation = p.policyNomineeRelation;
                    policy.policyPremiumPaymentFrequency = p.policyPremiumPaymentFrequency;
                    policy.filePath = p.filePath;
                    result.Add(policy);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        public List<GetPolicyResponse> GetPolicyByCustomerId(string id)
        {
            List<GetPolicyResponse> result = new List<GetPolicyResponse>();
            GetPolicyResponse policy = null;
            try
            {
                var policies = _dbContext.getPolicyByCustomerId(id);
                foreach (var p in policies)
                {
                    policy = new GetPolicyResponse();
                    policy.customerId = p.customerId;
                    policy.policyNumber = p.policyNumber;
                    policy.productId = p.productId;
                    policy.policyNominee = p.policyNominee;
                    policy.policyNomineeRelation = p.policyNomineeRelation;
                    policy.policyPremiumPaymentFrequency = p.policyPremiumPaymentFrequency;
                    policy.filePath = p.filePath;
                    result.Add(policy);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        public GetPolicyResponse GetPolicyByCustomerIdAndPolicyNumber(string custId, string policyNum)
        {
            GetPolicyResponse result = new GetPolicyResponse();
            try
            {
                var policies = _dbContext.getPolicyByCustomerIdAndPolicyNumber(custId, policyNum);
                foreach (var p in policies)
                {
                    result.customerId = p.customerId;
                    result.policyNumber = p.policyNumber;
                    result.productId = p.productId;
                    result.policyNominee = p.policyNominee;
                    result.policyNomineeRelation = p.policyNomineeRelation;
                    result.policyPremiumPaymentFrequency = p.policyPremiumPaymentFrequency;
                    result.filePath = p.filePath;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        public List<GetPolicyResponse> GetPolicyByCustomerNameAndDob(string name, DateTime DOB)
        {
            List<GetPolicyResponse> result = new List<GetPolicyResponse>();
            GetPolicyResponse policy = null;
            try
            {
                var policies = _dbContext.getPolicyByCustomerNameAndDob(name, DOB);
                foreach (var p in policies)
                {
                    policy = new GetPolicyResponse();
                    policy.policyNumber = p.policyNumber;
                    policy.customerId = p.customerId;
                    policy.productId = p.productId;
                    policy.policyNominee = p.policyNominee;
                    policy.policyNomineeRelation = p.policyNomineeRelation;
                    policy.policyPremiumPaymentFrequency = p.policyPremiumPaymentFrequency;
                    policy.filePath = p.filePath;
                    result.Add(policy);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        public GetPolicyResponse GetPolicyByPolicyNumber(string policyNum)
        {
            GetPolicyResponse result = new GetPolicyResponse();
            try
            {
                var policies = _dbContext.getPolicyByPolicyNumber(policyNum);
                foreach (var p in policies)
                {
                    result.customerId = p.customerId;
                    result.policyNumber = p.policyNumber;
                    result.productId = p.productId;
                    result.policyNominee = p.policyNominee;
                    result.policyNomineeRelation = p.policyNomineeRelation;
                    result.policyPremiumPaymentFrequency = p.policyPremiumPaymentFrequency;
                    result.filePath = p.filePath;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        public bool UpdatePolicy(UpdatePolicyRequest updatePolicyRequest)
        {
            bool flag = false;
            try
            {
                var updatePolicy = new Policy
                {
                    customerId = updatePolicyRequest.customerId,
                    policyNumber = updatePolicyRequest.policyNumber,
                    policyNominee = updatePolicyRequest.policyNominee,
                    policyNomineeRelation = updatePolicyRequest.policyNomineeRelation,
                    policyPremiumPaymentFrequency = updatePolicyRequest.policyPremiumPaymentFrequency,
                    filePath = updatePolicyRequest.filePath,
                    Customer = new Customer {
                        customerAddress = updatePolicyRequest.customerAddress,
                        customerTelephone = updatePolicyRequest.customerTelephone,
                        customerSmoker = updatePolicyRequest.customerSmoker
                     },
                };
                _dbContext.updatePolicy(updatePolicy.customerId, updatePolicy.policyNumber, updatePolicy.policyNominee, updatePolicy.policyNomineeRelation, updatePolicy.policyPremiumPaymentFrequency, updatePolicy.filePath, 
                    updatePolicy.Customer.customerAddress, updatePolicy.Customer.customerTelephone, updatePolicy.Customer.customerSmoker);

                flag = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return flag;
        }

        public ViewPolicyResponse ViewPolicy(string id)
        {
            ViewPolicyResponse result = new ViewPolicyResponse();
            try
            {
                var viewPolicy = _dbContext.getPolicy(id);
                foreach (var vp in viewPolicy)
                {
                    result.customerId = vp.customerId;
                    result.customerName = vp.Customer.customerName;
                    result.customerAddress =vp.Customer.customerAddress;
                    result.customerTelephone = vp.Customer.customerTelephone;
                    result.customerGender = vp.Customer.customerGender ;
                    result.customerDOB = vp.Customer.customerDOB;
                    result.customerSmoker = vp.Customer.customerSmoker;
                    result.productId = vp.productId;
                    result.productName = vp.InsuranceProduct.productName ;
                    result.productLine = vp.InsuranceProduct.productLine;
                    result.policyNumber = vp.policyNumber;
                    result.policyNominee = vp.policyNominee;
                    result.policyNomineeRelation = vp.policyNomineeRelation;
                    result.policyPremiumPaymentFrequency = vp.policyPremiumPaymentFrequency;
                    result.filePath = vp.filePath;
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