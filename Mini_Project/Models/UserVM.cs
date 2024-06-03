using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mini_Project.Models
{
    public class UserVM
    {
        //public Int64 UserID { get; set; }
        [Required(ErrorMessage ="Please enter the firstname")]
        public string FirstName { get; set; }

        [Required(ErrorMessage ="Please enter the lastname")]
        public string LastName { get; set; }

        [Required(ErrorMessage ="Please enter the address")]
        public string Address { get; set; }

        [Required(ErrorMessage ="Please enter the correct EmailID")]
        [EmailAddress]
        public string EmailID { get; set; }

        [Required(ErrorMessage ="Please enter the mobile no.")]
        public string MobileNo { get; set; }

        [Required(ErrorMessage ="Please enter the correct password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}