using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PESMVC.Data.DTO.Customer
{
    public class GetCustomerResponse
    {
        public string customerId { get; set; }
        public string customerName { get; set; }
        public string customerAddress { get; set; }
        public string customerTelephone { get; set; }
        public string customerGender { get; set; }
        public DateTime customerDOB { get; set; }
        public bool customerSmoker { get; set; }
        public string customerHobbies { get; set; }
    }
}
