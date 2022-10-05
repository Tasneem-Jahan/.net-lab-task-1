using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mid_Assignment_2.Models
{
    public class Form
    {
        [Required, StringLength(50, MinimumLength = 3), RegularExpression("^[A-Za-z][A-Za-z_. ,]{2,49}$", ErrorMessage = "Please enter a valid name!")]
        public string Name { get; set; }

        [Required, RegularExpression("[0-9]{2}-[0-9]{5}-[1-3]{1}", ErrorMessage = "Your ID format is incorrect!")]
        public string ID { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required, ValidateEmail]
        public string Email { get; set; }

        [Required, RegularExpression(".(?=.[A-Z])(?=.[a-z])(?=.[0-9])(?=.[!@#$ %^&~><.,:;]).*", ErrorMessage = "Password format is incorrect!")]
        public string Password { get; set; }

        [Compare("Password")]
        public string Confirm_Password { get; set; }

        [Required, ValidateBirthdate, DataType(DataType.Date)]
        public DateTime Date_Of_Birth { get; set; }
            
    }
}