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
    public class OrderDetails
    {
        [Key]
        [Column(Order = 1)]
        [Display(Name = "Mã hóa đơn")]
        public int order_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [Display(Name = "Mã sản phẩm")]
        public int product_ID { get; set; }

        [Display(Name = "Số lượng mua")]
        public int orderdetails_Quantity { get; set; }

        [Display(Name = "Giá bán")]
        [DataType(DataType.Currency)]
        public decimal orderdetails_ProductPrice { get; set; }
    }
}