using PESMVC.Data.DTO.InsuranceProducts;
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
    }
}
