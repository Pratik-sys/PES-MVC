using PESMVC.API.Interface;
using PESMVC.Data.DTO.InsuranceProducts;
using PESMVC.Data.Models;
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

        public List<GetInsuranceProductResponse> GetAllInsuranceProduct()
        {
            List<GetInsuranceProductResponse> result = new List<GetInsuranceProductResponse>();
            GetInsuranceProductResponse product = null;
            try
            {
                var insuranceProduct = _dbContext.getAllInsuranceProduct();
                foreach (var iP in insuranceProduct)
                {
                    product = new GetInsuranceProductResponse();
                    product.productId = iP.productId;
                    product.productName = iP.productName;
                    product.productLine = iP.productLine;
                    result.Add(product);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        public GetInsuranceProductResponse GetInsuranceProductById(string id)
        {
            GetInsuranceProductResponse result = new GetInsuranceProductResponse();
            try
            {
                var insuranceProduct = _dbContext.getInsuranceProductById(id);
                foreach(var product in insuranceProduct)
                {
                    result.productId = product.productId;
                    result.productName = product.productName;
                    result.productLine = product.productLine;
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
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