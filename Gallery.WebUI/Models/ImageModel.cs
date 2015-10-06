using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gallery.WebUI.Models
{
    public class ImageModel
    {
        [DisplayName("Title")]
        [Required(ErrorMessage = "This field is required")]
        [MaxLength(64, ErrorMessage = "Too Long")]
        public string Title { get; set; }

        [DisplayName("Description")]
        [DataType(DataType.MultilineText)]
        [MaxLength(1024, ErrorMessage = "Too Long")]
        public string Description { get; set; }

        [DisplayName("Select Image")]
        [Required(ErrorMessage = "File required")]
        [DataType(DataType.Upload)]
        public HttpPostedFile Image { get; set; }
    }
}