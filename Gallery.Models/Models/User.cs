using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery.Models.Models
{
    public class User
    {
        [Key]
        public int UserId;
        [Required]
        public string Email;
        [Required]
        public string Password;
        public string FirstName;
        public string LastName;
        public string Roles;
    }
}
