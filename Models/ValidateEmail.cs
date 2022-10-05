using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mid_Assignment_2.Models
{
    public sealed class ValidateEmail : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                Form user = (Form)validationContext.ObjectInstance; // storing the model inputs
                string email = value.ToString();
                string emailData1 = email.Substring(0, 10);
                string emailData2 = email.Substring(10);
                if (emailData1 == user.ID)
                {
                    if (emailData2 == "@aiub.edu")
                    {
                        return ValidationResult.Success;
                    }
                    else
                    {
                        return new ValidationResult("Incorrect email format!");
                    }
                }
                else
                {
                    return new ValidationResult("Does not match with the ID!");
                }
            }
            return new ValidationResult("No data found!");
        }
    }
}