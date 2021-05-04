﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PESMVC.Data.DTO.Policy
{
    public class SearchByCustomerIdResponse
    {
        public int Id { get; set; }
        public string policyNumber { get; set; }
        public string customerId { get; set; }
        public string productId { get; set; }
        public string policyNominee { get; set; }
        public string policyNomineeRelation { get; set; }
        public string policyPremiumPaymentFrequency { get; set; }
        public string filePath { get; set; }
    }
}
