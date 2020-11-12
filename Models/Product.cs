using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace CellphoneStoreEcommerce.Models
{
    public class Product
    {
        [Key]
        public string product_ID { get; set; }

        [Required(ErrorMessage = "Nhập thông tin cho trường này!!!")]
        [Display(Name = "Tên sản phẩm")]
        public string product_Name { get; set; }

        [Required(ErrorMessage = "Nhập thông tin cho trường này!!!")]
        [Display(Name = "Giá sản phẩm")]
        [Range(10000, 100000000, ErrorMessage = "Giá thấp nhất là 10,000vnđ và tối đa là 100,000,000vnđ")]
        public double product_Price { get; set; }

        [Required(ErrorMessage = "Nhập thông tin cho trường này!!!")]
        [Display(Name = "Số lượng sản phẩm")]
        [Range(1, 1000, ErrorMessage = "Số lượng tối thiểu là 1 và tối đa là 1,000")]
        public int product_Quantity { get; set; }

        [Display(Name = "Hệ điều hành sản phẩm")]
        public string product_OS { get; set; }

        [Display(Name = "Mô tả sản phẩm")]
        public string product_Description { get; set; }

        public Product() { }

        public Product(string product_Name, double product_Price, int product_Quantity, string product_OS)
        {
            this.product_Name = product_Name;
            this.product_Price = product_Price;
            this.product_Quantity = product_Quantity;
            this.product_OS = product_OS;
        }
    }
}
