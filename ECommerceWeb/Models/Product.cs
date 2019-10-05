using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerceWeb.Models
{
    public class Product
    {
        [Display(Name = "Product ID")]
        public string ProductId { get; set; }

        [Display(Name = "Product Name ")]
        public string ProductName { get; set; }

        [Display(Name = "Stock Qty")]
        public int StockQty { get; set; }

        [Display(Name = "Unit Price ")]
        public double UnitPrice { get; set; }
    }
}