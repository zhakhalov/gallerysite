using Gallery.WebUI.Models.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gallery.WebUI.Models
{
    public class TagModel
    {
        [DisplayName("Title")]
        [Required(ErrorMessage = "This field is required")]
        [UniqueTagTitle(ErrorMessage = "Tag already exists")]
        public string Title { get; set; }
    }
}