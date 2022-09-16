using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineShop.Db;
using OnlineShopWebApp.Helpers;
using OnlineShopWebApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductsRepository productRepository;

        public HomeController(IProductsRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var products = productRepository.GetAll();
            return View(Mapping.ToProductsViewModels(products));
        }

        [HttpPost]
        public IActionResult Search(string searchName)
        {
            if (searchName == null)
                return RedirectToAction("Index");
            var products = productRepository.SearchByName(searchName);
            return View(Mapping.ToProductsViewModels(products));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        
    }
}
