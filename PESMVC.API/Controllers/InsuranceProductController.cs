using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PESMVC.API.Interface;
using PESMVC.Data.DTO.InsuranceProducts;

namespace PESMVC.API.Controllers
{
    public class InsuranceProductController : ApiController
    {
        private readonly IInsuranceProductService _insuranceProductService;

        public InsuranceProductController(IInsuranceProductService insuranceProductService)
        {
            _insuranceProductService = insuranceProductService;
        }

        [HttpPost]
        public IHttpActionResult CreateInsuranceProduct([FromBody] CreateInsuranceProductRequest insuranceProductRequest)
        {
            string message = "Failed";
            if (_insuranceProductService.CreateInsuranceProduct(insuranceProductRequest))
            {
                message = "Success";
            }
            return Ok(message);
        }

        [HttpPut]
        public IHttpActionResult UpdateInsuranceProduct([FromBody] UpdateInsuranceProductRequest insuranceProductRequest)
        {
            string message = "Failed";
            if (_insuranceProductService.UpdateInsuranceProduct(insuranceProductRequest))
            {
                message = "Success";
            }
            return Ok(message);
        }
    
        [HttpDelete]
        public IHttpActionResult DeleteInsuranceProduct(string id)
        {
            string message = "Failed";
            if(id != null)
            {
                if (_insuranceProductService.DeleteInsuranceProduct(id))
                {
                    message = "Success";
                }
            }
            return Ok(message);
        }

    }
}
