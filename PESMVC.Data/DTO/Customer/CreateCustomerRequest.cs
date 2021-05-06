using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PESMVC.Data.DTO.Customer
{
    public class CreateCustomerRequest
    {
        [Required]
        [StringLength(100)]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Invalid UserName")]
        public string customerName { get; set; }

        [Required(ErrorMessage ="Please Enter the Address")]
        public string customerAddress { get; set; }

        [Required(ErrorMessage ="Please Enter the Telephone")]
        [MaxLength(10,ErrorMessage = "Invalid Telephone Number")]
        [RegularExpression("^[0-9]*$" , ErrorMessage= "Number should be of 10 ")]
        public string customerTelephone { get; set; }

        [Required(ErrorMessage ="Please Select Geneder")]
        public string customerGender { get; set; }

        [Required(ErrorMessage = "Please Enter the Date ")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}") ]
        public System.DateTime customerDOB { get; set; }

        [Required]
        public bool customerSmoker { get; set; }

        [Required(ErrorMessage ="Hobbies can't be Empty")]
        public string customerHobbies { get; set; }
    }
}
