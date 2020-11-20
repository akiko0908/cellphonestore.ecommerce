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
    public class Customer
    {
        [Key]
        [Display(Name = "Mã khách hàng")]
        public int customer_ID { get; set; }

        [Display(Name = "Tên khách hàng")]
        public string customer_Name { get; set; }

        [Display(Name = "SĐT")]
        [Range(10, 11, ErrorMessage = "Số điện thoại có từ 10 - 11 ký số")]
        public string customer_NumberPhone { get; set; }

        public string customer_Email { get; set; }

        public string customer_Address1 { get; set; }

        public string customer_Address2 { get; set; }

        // Foreign Key
        [ForeignKey("User")]
        public int user_ID { get; set; }

        // Get list
        public IEnumerable<Order> lsOrder { get; set; }
    }
}