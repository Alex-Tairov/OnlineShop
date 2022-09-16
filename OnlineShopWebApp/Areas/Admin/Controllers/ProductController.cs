using Microsoft.AspNetCore.Mvc;
using OnlineShop.Db;
using OnlineShop.Db.Models;
using OnlineShopWebApp.Helpers;
using OnlineShopWebApp.Models;
using System;
using Microsoft.AspNetCore.Authorization;

namespace OnlineShopWebApp.Areas.Admin.Controllers
{
    [Area(Constants.AdminRoleName)]
    [Authorize(Roles = Constants.AdminRoleName)]
    public class ProductController : Controller
    {
        private readonly IProductsRepository productRepository;
   
        public ProductController(IProductsRepository productsRepository)
        {
            this.productRepository = productsRepository;
           
        }
        
        public IActionResult Index()
        {
            var products = productRepository.GetAll();
            return View(Mapping.ToProductsViewModels(products));
        }
        public IActionResult Remove(Guid productId)
        {
            productRepository.RemoveProduct(productId);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(Guid productId)
        {
            var product = productRepository.TryGetById(productId);
            return View(Mapping.ToProductViewModel(product));
        }
        [HttpPost]
        public IActionResult Edit(ProductViewModel product)
        {
            if (ModelState.IsValid)
            {
                productRepository.EditProduct(Mapping.ToProductDb(product));
                return RedirectToAction(nameof(Index));
            }
            return View("Edit", product);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(ProductViewModel newProduct)
        {
            if (ModelState.IsValid)
            {
                var productDb = new Product
                {
                    Name = newProduct.Name,
                    Cost = newProduct.Cost,
                    Description = newProduct.Description,
                };
                productRepository.Add(productDb);
                return RedirectToAction(nameof(Index));
            }
            return View("Add", newProduct);
        }
    }
}
