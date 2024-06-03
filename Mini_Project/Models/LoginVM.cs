using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Mini_Project.Models
{
    public class LoginVM
    {
        [Required(ErrorMessage ="EmailId is mandatory")]
        [EmailAddress]
        public string EmailID { get; set; }

        [Required(ErrorMessage ="Password is mandatory")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}