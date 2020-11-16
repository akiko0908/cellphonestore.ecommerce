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

        [Display(Name = "Số điện thoại")]
        [Range(10, 11, ErrorMessage = "Số điện thoại phải có 10 hoặc 11 số!!!")]
        public string customer_NumberPhone { get; set; }

        [Display(Name = "Địa chỉ 1")]
        public string customer_AddressOne { get; set; }

        [Display(Name = "Địa chỉ 2")]
        public string customer_AddressTwo { get; set; }

        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ!!!")]
        public string customer_Email { get; set; }
    }
}