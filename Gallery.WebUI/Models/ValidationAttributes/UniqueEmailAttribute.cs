using Gallery.DAL.Abstract.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gallery.WebUI.Models.ValidationAttributes
{
    public class UniqueEmailAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DependencyResolver.Current.GetService<IUserRepository>().FindOne(entry => entry.Email == value.ToString());
            return true;
        }
    }
}