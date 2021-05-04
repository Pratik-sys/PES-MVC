﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PESMVC.Data.Models.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class PES_TestEntities : DbContext
    {
        public PES_TestEntities()
            : base("name=PES_TestEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AdminLoginCredential> AdminLoginCredentials { get; set; }
        public virtual DbSet<CustomerLoginCredential> CustomerLoginCredentials { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Endorsement> Endorsements { get; set; }
        public virtual DbSet<InsuranceProduct> InsuranceProducts { get; set; }
        public virtual DbSet<Policy> Policies { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<EndorsementStatu> EndorsementStatus { get; set; }
    
        public virtual int createInsuranceProduct(string productName, string productLine)
        {
            var productNameParameter = productName != null ?
                new ObjectParameter("productName", productName) :
                new ObjectParameter("productName", typeof(string));
    
            var productLineParameter = productLine != null ?
                new ObjectParameter("productLine", productLine) :
                new ObjectParameter("productLine", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("createInsuranceProduct", productNameParameter, productLineParameter);
        }
    
        public virtual int updateInsuranceProduct(string productId, string productName, string productLine)
        {
            var productIdParameter = productId != null ?
                new ObjectParameter("productId", productId) :
                new ObjectParameter("productId", typeof(string));
    
            var productNameParameter = productName != null ?
                new ObjectParameter("productName", productName) :
                new ObjectParameter("productName", typeof(string));
    
            var productLineParameter = productLine != null ?
                new ObjectParameter("productLine", productLine) :
                new ObjectParameter("productLine", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updateInsuranceProduct", productIdParameter, productNameParameter, productLineParameter);
        }
    
        public virtual int deleteInsuranceProduct(string insuranceId)
        {
            var insuranceIdParameter = insuranceId != null ?
                new ObjectParameter("insuranceId", insuranceId) :
                new ObjectParameter("insuranceId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deleteInsuranceProduct", insuranceIdParameter);
        }
    
        public virtual ObjectResult<Endorsement> searchInsuranceProductById(string insuranceId)
        {
            var insuranceIdParameter = insuranceId != null ?
                new ObjectParameter("insuranceId", insuranceId) :
                new ObjectParameter("insuranceId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Endorsement>("searchInsuranceProductById", insuranceIdParameter);
        }
    
        public virtual ObjectResult<Endorsement> searchInsuranceProductById(string insuranceId, MergeOption mergeOption)
        {
            var insuranceIdParameter = insuranceId != null ?
                new ObjectParameter("insuranceId", insuranceId) :
                new ObjectParameter("insuranceId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Endorsement>("searchInsuranceProductById", mergeOption, insuranceIdParameter);
        }
    }
}
