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
    public class Product
    {
        [Key]
        public string product_ID { get; set; }
        public string product_Name { get; set; }
        public double product_Price { get; set; }
        public int product_Quantity { get; set; }
        public string product_OS { get; set; }

        public Product() { }

        public Product(string product_Name, double product_Price, int product_Quantity, string product_OS)
        {
            this.product_Name = product_Name;
            this.product_Price = product_Price;
            this.product_Quantity = product_Quantity;
            this.product_OS = product_OS;
        }
    }
}
