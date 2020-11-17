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
        [Display(Name = "Mã sản phẩm")]
        [Key]
        [Column(Order = 1)]
        public int product_ID { get; set; }

        [Display(Name = "Mã hóa đơn")]
        [Key]
        [Column(Order = 2)]
        public int order_ID { get; set; }

        [Display(Name = "Số lượng mua")]
        public int Soluong { get; set; }

        [ForeignKey("Customer")]
        [Display(Name = "Mã khách hàng")]
        public int customer_ID { get; set; }
    }
}