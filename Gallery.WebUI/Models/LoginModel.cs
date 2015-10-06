using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gallery.WebUI.Models
{
    public class LoginModel
    {
        [DisplayName("Email")]
        [Required(ErrorMessage = "This field is required")]
        public string Email { get; set; }

        [DisplayName("Password")]
        [Required(ErrorMessage = "This field is required")]
        public string Password { get; set; }
    }
}