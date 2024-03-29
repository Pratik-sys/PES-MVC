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
    
    public partial class Policy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Policy()
        {
            this.Endorsements = new HashSet<Endorsement>();
            this.EndorsementStatus = new HashSet<EndorsementStatu>();
        }
    
        public int Id { get; set; }
        public string policyNumber { get; set; }
        public string customerId { get; set; }
        public string productId { get; set; }
        public string policyNominee { get; set; }
        public string policyNomineeRelation { get; set; }
        public string policyPremiumPaymentFrequency { get; set; }
        public string filePath { get; set; }
    
        public virtual Customer Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Endorsement> Endorsements { get; set; }
        public virtual InsuranceProduct InsuranceProduct { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EndorsementStatu> EndorsementStatus { get; set; }
    }
}
