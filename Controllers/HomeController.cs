using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CellphoneStoreEcommerce.Models;

namespace CellphoneStoreEcommerce.Controllers
{
    public class HomeController : Controller
    {
        private List<Product> lsProduct = new List<Product>(){
                new Product { product_ID = 1,
                                product_Name = "iPhone 11",
                                product_Quantity = 100,
                                product_Description = "iPhone 11 - 64GB",
                                product_Image = "iphone-11.png",
                                product_OS = "iOS",
                                product_Price = 1200,
                                nhacungcap_ID = 1,
                                proCategory_ID = 1
                },
                new Product { product_ID = 2,
                                product_Name = "iPhone 12",
                                product_Quantity = 110,
                                product_Description = "iPhone 12 - 64GB",
                                product_Image = "iphone-12.png",
                                product_OS = "iOS",
                                product_Price = 1250,
                                nhacungcap_ID = 1,
                                proCategory_ID = 1
                },
                new Product { product_ID = 3,
                                product_Name = "iPhone 12 Pro",
                                product_Quantity = 120,
                                product_Description = "iPhone 12 Pro - 64GB",
                                product_Image = "iphone-12-pro.png",
                                product_OS = "iOS",
                                product_Price = 1450,
                                nhacungcap_ID = 1,
                                proCategory_ID = 1
                },
                new Product { product_ID = 4,
                                product_Name = "Samsung Galaxy S20",
                                product_Quantity = 100,
                                product_Description = "Samsung Galaxy S20 - 128GB",
                                product_Image = "samsung-galaxy-s20.png",
                                product_OS = "Android",
                                product_Price = 1500,
                                nhacungcap_ID = 1,
                                proCategory_ID = 2
                },
                new Product { product_ID = 5,
                                product_Name = "OPPO A93",
                                product_Quantity = 100,
                                product_Description = "Oppo A93 - New 100%",
                                product_Image = "oppo-a93.png",
                                product_OS = "Android",
                                product_Price = 1000,
                                nhacungcap_ID = 1,
                                proCategory_ID = 3
                },
                new Product { product_ID = 6,
                                product_Name = "Xiaomi Mi 10T Pro",
                                product_Quantity = 100,
                                product_Description = "Xiaomi Mi 10T Pro 128GB - New 100%",
                                product_Image = "xiaomi-mi-10t-pro.png",
                                product_OS = "Android",
                                product_Price = 1050,
                                nhacungcap_ID = 1,
                                proCategory_ID = 4
                }
            };

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(lsProduct);
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            List<Product> ls = lsProduct;
            Product product = lsProduct.Where(m => m.product_ID == id).FirstOrDefault();
            return View(product);
        }

        [HttpPost]
        public IActionResult Search(string stringSearch)
        {
            if (!string.IsNullOrEmpty(stringSearch))
            {
                List<Product> resultProduct = lsProduct.Where(m => m.product_Name.ToLower().Contains(stringSearch.ToLower())).ToList();
                return View(resultProduct);
            }
            else return RedirectToAction("Index", "Home");
        }

        public IActionResult Privacy()
        {
            return View();
        }




        // Process improve erro
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
