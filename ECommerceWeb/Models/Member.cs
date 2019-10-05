using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerceWeb.Models
{
    public class Member
    {
        [Display(Name = "Login ID")]
        [StringLength(16, MinimumLength = 8, ErrorMessage = "Password must be atleast 8 character and must not exceed 16 character. ")]
        [Required(ErrorMessage = "Please enter the Login ID.")]
        public int MemberId { get; set; }

        [Display(Name = "Member Role")]
        [Required(ErrorMessage = "Please select the member role.")]
        public string MemberRole { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please enter the first name.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter the last name.")]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Please enter the email address.")]
        public string EmailAddress { get; set; }

        [Display(Name = "Confirm Email")]
        [Compare("EmailAddress", ErrorMessage = "The email and confirm email must match.")]
        public string ConfirmEmail { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please enter the password.")]
        [StringLength(20, MinimumLength = 10, ErrorMessage = "Password must be atleast 10 character and must not exceed 20 character. ")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please enter the confirm password.")]
        [Compare("Password", ErrorMessage = "The password and confirm password must match.")]
        public string ComfirmPassword { get; set; }


    }
}