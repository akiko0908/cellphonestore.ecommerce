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
    public class Order
    {
        [Key]
        [Display(Name = "Mã hóa đơn")]
        public int order_ID { get; set; }

        [Display(Name = "Ngày đặt hàng")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime order_CreateOnDay { get; set; }

        [Display(Name = "Tình trạng đơn hàng")]
        public int order_Status { get; set; }

        [Display(Name = "Ngày cập nhập")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime order_UpdateOnDay { get; set; }

        [Display(Name = "Tổng tiền đơn hàng")]
        [DataType(DataType.Currency)]
        public decimal order_Total { get; set; }

        [Display(Name = "Phương thức thanh toán")]
        public string order_PaymentMethod { get; set; }

        [Display(Name = "Tiền chiết khấu")]
        [DataType(DataType.Currency)]
        public decimal order_AmountDiscount { get; set; }

        // Foreign Key
        [ForeignKey("Customer")]
        public int customer_ID { get; set; }

        [ForeignKey("PhiVanChuyen")]
        public int service_ID { get; set; }

        [ForeignKey("KhuyenMai")]
        public int promotion_ID { get; set; }
    }
}