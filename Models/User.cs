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
    public class User
    {
        [Key]
        [Display(Name = "Mã người dùng")]
        public int user_ID { get; set; }

        [Display(Name = "Username")]
        public string user_Name { get; set; }

        [Display(Name = "Password")]
        public string user_Password { get; set; }

        [Display(Name = "Tên người dùng")]
        public string user_Fullname { get; set; }

        [Display(Name = "Email")]
        public string user_Email { get; set; }
    }
}