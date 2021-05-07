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
        public IHttpActionResult CreateInsuranceProductApi([FromBody] CreateInsuranceProductRequest insuranceProductRequest)
        {
            string message = "Failed";
            if (_insuranceProductService.CreateInsuranceProduct(insuranceProductRequest))
            {
                message = "Success";
            }
            return Ok(message);
        }

        [HttpPut]
        public IHttpActionResult UpdateInsuranceProductApi([FromBody] UpdateInsuranceProductRequest insuranceProductRequest)
        {
            string message = "Failed";
            if (_insuranceProductService.UpdateInsuranceProduct(insuranceProductRequest))
            {
                message = "Success";
            }
            return Ok(message);
        }
    
        [HttpDelete]
        public IHttpActionResult DeleteInsuranceProductApi(string id)
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

        [HttpGet]
        public GetInsuranceProductResponse GetInsuranceProductApi(string id)
        {
            var result = new GetInsuranceProductResponse();
            try
            {
                result = _insuranceProductService.GetInsuranceProductById(id);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public List<GetInsuranceProductResponse> GetAllInsuranceProductsApi()
        {
            var result = new List<GetInsuranceProductResponse>();
            try
            {
                result = _insuranceProductService.GetAllInsuranceProduct();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }
    }
}
