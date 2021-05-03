using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PESMVC.Data.DTO.InsuranceProducts
{
    public class CreateInsuranceProductRequest
    {
        [Required]
        public string productName { get; set; }
        [Required]
        public string productLine { get; set; }
    }
}
