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
    public class PhiVanChuyen
    {
        [Key]
        [Display(Name = "Mã phí vận chuyển")]
        public int service_ID { get; set; }

        [Required(ErrorMessage = "Tên khu vực phải được điền thông tin!!!")]
        [Display(Name = "Tên khu vực")]
        public string TenKhuVuc { get; set; }

        [Required(ErrorMessage = "Giá vận chuyển phải được nhập!!!")]
        [Display(Name = "Giá vận chuyển")]
        [Range(15000, 1000000, ErrorMessage = "Phí vận chuyển phải từ 15,000 - 1,000,000vnđ!!!")]
        [DataType(DataType.Currency)]
        public decimal GiaVanChuyen { get; set; }
    }
}