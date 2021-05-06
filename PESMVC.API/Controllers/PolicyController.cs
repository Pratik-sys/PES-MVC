﻿using PESMVC.API.Interface;
using PESMVC.Data.DTO.Policy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PESMVC.API.Controllers
{
    public class PolicyController : ApiController
    {
        private readonly IPolicyServices _policyService;

        public PolicyController(IPolicyServices policyService)
        {
            _policyService = policyService;
        }

        [HttpGet]
        public List<GetPolicyResponse> GetAllPolicyApi()
        {
            var result = new List<GetPolicyResponse>();
            try
            {
                result = _policyService.GetAllPolicy();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        [HttpGet]
        public List<GetPolicyResponse> GetPolicyByCustIdApi(string id)
        {
            var result = new List<GetPolicyResponse>();
            try
            {
                result = _policyService.GetPolicyByCustomerId(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        [HttpGet]
        public List<GetPolicyResponse> GetPolicyByCustNameAndDobApi(string name, DateTime DOB)
        {
            var result = new List<GetPolicyResponse>();
            try
            {
                result = _policyService.GetPolicyByCustomerNameAndDob(name, DOB);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        [HttpGet]
        public GetPolicyResponse GetPolicyByPNApi(string policyNum)
        {
            var result = new GetPolicyResponse();
            try
            {
                result = _policyService.GetPolicyByPolicyNumber(policyNum);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        [HttpGet]
        public GetPolicyResponse GetPolicyByCustIdAndpNApi(string custId, string policyNum)
        {
            var result = new GetPolicyResponse();
            try
            {
                result = _policyService.GetPolicyByCustomerIdAndPolicyNumber(custId, policyNum);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        [HttpPost]
        public IHttpActionResult ApplyForPolicyApi([FromBody] ApplyForPolicyRequest applyForPolicyRequest)
        {
            string message = "Failed";
            if (_policyService.ApplyForPolicy(applyForPolicyRequest))
            {
                message = "Success";
            }
            return Ok(message);
        }

        [HttpPut]
        public IHttpActionResult UpdatePolicyApi([FromBody]UpdatePolicyRequest updatePolicyRequest)
        {
            string message = "Failed";
            if (_policyService.UpdatePolicy(updatePolicyRequest))
            {
                message = "Success";
            }
            return Ok(message);
        }

        [HttpGet]
        public ViewPolicyResponse ViewPolicyApi(string id)
        {
            var result = new ViewPolicyResponse();
            try
            {
                result = _policyService.ViewPolicy(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }
    }
}