using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCapp.Models
{
    public class EmpolyeeModel
    {
        [Display(Name ="Employee ID")]
        [Range(100000, 999999, ErrorMessage = "You should Enter a valid Employee ID")]
        public int EmployeeID { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage =" You must provide your first name")]
        public String FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = " You must provide your Last name")]
        public String LastName { get; set; }
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = " You must provide your Email Address")]
        public String EmailAddress { get; set; }

        [Display(Name = "Confirm Email Address")]
        [Compare("EmailAddress",ErrorMessage =" The Emails Not Match")]
        public String ConfirmEmail { get; set; }

        [DataType(DataType.Password )]
        [StringLength(100,MinimumLength = 8,ErrorMessage ="Enter a long Enough Password")]
        public String Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Your Password and Your Confirmation Not Match")]
        public string ConfirmPassword { get; set; }
    }
}