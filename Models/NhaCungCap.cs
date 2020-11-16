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
    public class NhaCungCap
    {
        [Key]
        [Display(Name = "Mã nhà cung cấp")]
        public int nhacungcap_ID { get; set; }

        [Display(Name = "Tên nhà cung cấp")]
        public string nhacungcap_Name { get; set; }

        // get list of products by supplier code
        public IEnumerable<Product> lsProducts { get; set; }
    }
}