using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PESMVC.API.Auth.Models
{
    public partial class UserEntities : DbContext
    {
        public UserEntities()
            : base("name=UserEntities")
        {
        }

        public virtual DbSet<LoginCredential> LoginCredentials { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoginCredential>()
                .Property(e => e.loginId)
                .IsUnicode(false);

            modelBuilder.Entity<LoginCredential>()
                .Property(e => e.pswd)
                .IsUnicode(false);

            modelBuilder.Entity<LoginCredential>()
                .Property(e => e.roleType)
                .IsUnicode(false);
        }
    }
}
