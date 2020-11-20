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
    public class Comment
    {
        [Key]
        [Display(Name = "Mã comment")]
        public int comment_ID { get; set; }

        [Display(Name = "Nội dung comment")]
        public string comment_Content { get; set; }

        // Foreign Key
        [ForeignKey("Product")]
        public int product_ID { get; set; }

        [ForeignKey("Customer")]
        public int customer_ID { get; set; }
    }
}