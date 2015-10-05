using Gallery.WebUI.Models.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gallery.WebUI.Models
{
    public class RegistrationModel
    {
        [Required(ErrorMessage = "This field is required")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("E-mail")]
        [Required(ErrorMessage = "This field is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [EqualsTo("Password", ErrorMessage = "Password does not match confirmation")]
        public string RePassword { get; set; }
    }
}