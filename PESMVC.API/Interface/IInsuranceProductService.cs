using PESMVC.Data.DTO.InsuranceProducts;
using PESMVC.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PESMVC.API.Interface
{
    public interface IInsuranceProductService
    {
        bool CreateInsuranceProduct(CreateInsuranceProductRequest insuranceProductRequest);

        bool UpdateInsuranceProduct(UpdateInsuranceProductRequest insuranceProductRequest);

        bool DeleteInsuranceProduct(string id);

        GetInsuranceProductByIdResponse GetInsuranceProductById(string id);

        List<GetAllInsuranceProductsResponse> GetAllInsuranceProduct();
    }
}
