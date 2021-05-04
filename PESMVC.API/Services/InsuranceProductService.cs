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

        public bool DeleteInsuranceProduct(string id)
        {
            bool flag = false;
            try
            {
                _dbContext.deleteInsuranceProduct(id);
                flag = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return flag;
        }

        public List<GetAllInsuranceProductsResponse> GetAllInsuranceProduct()
        {
            throw new NotImplementedException();
        }

        public GetInsuranceProductByIdResponse GetInsuranceProductById(string id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateInsuranceProduct(UpdateInsuranceProductRequest insuranceProductRequest)
        {
            bool flag = false;
            try
            {
                var insuranceProduct = new InsuranceProduct
                {
                    productId = insuranceProductRequest.productId,
                    productName = insuranceProductRequest.productName,
                    productLine = insuranceProductRequest.productLine
                };

                _dbContext.updateInsuranceProduct(insuranceProduct.productId, insuranceProduct.productName, insuranceProduct.productLine);

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