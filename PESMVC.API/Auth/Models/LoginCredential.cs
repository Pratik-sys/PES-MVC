namespace PESMVC.API.Auth.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LoginCredential
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(7)]
        public string loginId { get; set; }

        [Required]
        [StringLength(7)]
        public string pswd { get; set; }

        [StringLength(5)]
        public string roleType { get; set; }
    }
}
