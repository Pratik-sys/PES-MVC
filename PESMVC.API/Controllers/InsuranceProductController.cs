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
        public IHttpActionResult PostInsuranceProduct([FromBody] CreateInsuranceProductRequest insuranceProductRequest)
        {
            string message = "Failed";
            if (_insuranceProductService.CreateInsuranceProduct(insuranceProductRequest))
            {
                message = "Success";
            }
            return Ok(message);
        }
    }
}
