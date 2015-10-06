using Gallery.DAL.Abstract.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gallery.WebUI.Models.ValidationAttributes
{
    public class UniqueTagTitleAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return null == DependencyResolver.Current.GetService<ITagRepository>().FindOne(entry => entry.Title == value.ToString());
        }
    }
}