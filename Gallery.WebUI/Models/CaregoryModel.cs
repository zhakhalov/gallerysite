using Gallery.WebUI.Models.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gallery.WebUI.Models
{
    public class CaregoryModel
    {
        [DisplayName("Category Title")]
        [Required(ErrorMessage="This field is required")]
        [UniqueCategoryTitle(ErrorMessage="Category with this title already exists")]
        public string Title { get; set; }

        [DisplayName("Category Image")]
        public HttpPostedFile Image { get; set; }
    }
}