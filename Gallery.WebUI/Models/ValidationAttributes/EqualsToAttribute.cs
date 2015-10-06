using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gallery.WebUI.Models.ValidationAttributes
{
    public class EqualsToAttribute : ValidationAttribute
    {
        public string OtherProperty { get; private set; }
        public EqualsToAttribute(string otherProperty)
        {
            this.OtherProperty = otherProperty;
        }

        protected override ValidationResult IsValid(object value, ValidationContext context)
        {
            return context.ObjectType.GetProperty(this.OtherProperty).GetValue(context.ObjectInstance) == value
                ? ValidationResult.Success
                : new ValidationResult(this.ErrorMessage);
        }
    }
}