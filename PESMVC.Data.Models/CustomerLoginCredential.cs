//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PESMVC.Data.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustomerLoginCredential
    {
        public int Id { get; set; }
        public string loginId { get; set; }
        public string customerId { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}