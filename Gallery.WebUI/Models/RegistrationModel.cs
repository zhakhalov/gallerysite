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
        [DisplayName("First Name")]
        [Required(ErrorMessage = "This field is required")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "This field is required")]
        public string LastName { get; set; }

        [DisplayName("E-mail")]
        [Required(ErrorMessage = "This field is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [DisplayName("Password")]
        [Required(ErrorMessage = "This field is required")]
        public string Password { get; set; }

        [DisplayName("Re-enter password")]
        [Required(ErrorMessage = "This field is required")]
        [EqualsTo("Password", ErrorMessage = "Password does not match confirmation")]
        public string RePassword { get; set; }
    }
}