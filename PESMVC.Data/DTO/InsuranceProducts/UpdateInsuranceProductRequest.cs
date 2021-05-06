using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PESMVC.Data.DTO.InsuranceProducts
{
    public class UpdateInsuranceProductRequest
    {
        [Required]
        [MaxLength(7)]
        [RegularExpression("^[A-Z0-9]*$", ErrorMessage = "Product Id cannot be empty or contain special characters")]
        public string productId { get; set; }

        [Required]
        [RegularExpression(@"^[A-Za-z0-9\s]+$", ErrorMessage = "Product Name cannot be empty or contain special characters")]
        public string productName { get; set; }
        
        [Required]
        public string productLine { get; set; }
    }
}
