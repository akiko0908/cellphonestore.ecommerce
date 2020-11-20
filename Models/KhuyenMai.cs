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
    public class KhuyenMai
    {
        [Key]
        [Display(Name = "Mã khuyến mãi")]
        public int promotion_ID { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên chương trình khuyến mãi!!!")]
        [Display(Name = "Tên khuyến mãi")]
        public string promotion_Name { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập ngày bắt đầu khuyến mãi!!!")]
        [Display(Name = "Ngày bắt đầu")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime promotion_StartDay { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập ngày kết thúc khuyến mãi!!!")]
        [Display(Name = "Ngày kết thúc")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime promotion_EndDay { get; set; }

        [Required(ErrorMessage = "Nhập phần trăm được chiết khấu!!!")]
        [Display(Name = "Phần trăm khuyến mãi")]
        [Range(5, 70, ErrorMessage = "Chiết khấu từ 5 - 70%!!!")]
        public int promotion_Percent { get; set; }
    }
}
