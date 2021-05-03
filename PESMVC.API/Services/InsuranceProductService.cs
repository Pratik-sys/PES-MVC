using PESMVC.API.Interface;
using PESMVC.Data.DTO.InsuranceProducts;
using PESMVC.Data.Models;
using PESMVC.Data.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PESMVC.API.Services
{
    public class InsuranceProductService: IInsuranceProductService
    {
        private readonly PES_TestEntities _dbContext;
        public InsuranceProductService(PES_TestEntities dbContext)
        {
            _dbContext = dbContext;
        }

        public bool CreateInsuranceProduct(CreateInsuranceProductRequest insuranceProductRequest)
        {
            bool flag = false;
            try
            {
                var insuranceProduct = new InsuranceProduct
                {
                    productName = insuranceProductRequest.productName,
                    productLine = insuranceProductRequest.productLine
                };

                _dbContext.createInsuranceProduct(insuranceProduct.productName, insuranceProduct.productLine);

                flag = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return flag;
        }
    }
}