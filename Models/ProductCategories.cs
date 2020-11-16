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
    public class ProductCategories
    {
        [Key]
        [Display(Name = "Mã loại sản phẩm")]
        public int proCategory_ID { get; set; }

        [Display(Name = "Tên loại sản phẩm")]
        public string proCategory_Name { get; set; }

        // Get list product in ProductCategories
        public IEnumerable<Product> lsProducts { get; set; }
    }
}