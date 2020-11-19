using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CellphoneStoreEcommerce.Models;
using CellphoneStoreEcommerce.Data;

namespace CellphoneStoreEcommerce.Controllers
{
    public class ProductController : Controller
    {
        public ProductController() { }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product newProduct)
        {
            return View();
        }

        public IActionResult Details(int? i)
        {
            return View();
        }
    }
}