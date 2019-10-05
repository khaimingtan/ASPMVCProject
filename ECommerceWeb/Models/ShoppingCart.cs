using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerceWeb.Models
{
    public class ShoppingCart
    {
        [Display(Name = "Login ID")]
        [StringLength(16, MinimumLength = 8, ErrorMessage = "Password must be atleast 8 character and must not exceed 16 character. ")]
        [Required(ErrorMessage = "Please enter the Login ID.")]
        public int MemberId { get; set; }

        [Display(Name = "Product ID")]
        public string ProductId { get; set; }

        [Display(Name = "Product Name ")]
        public string ProductName { get; set; }

        [Display(Name = "Quantity ")]
        public int Quantity { get; set; }

        [Display(Name = "Unit Price ")]
        public string UnitPrice { get; set; }
    }
}