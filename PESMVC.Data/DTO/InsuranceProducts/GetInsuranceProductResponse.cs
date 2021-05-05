using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PESMVC.Data.DTO.InsuranceProducts
{
    public class GetInsuranceProductResponse
    {
        public string productId { get; set; }

        public string productName { get; set; }

        public string productLine { get; set; }
    }
}
