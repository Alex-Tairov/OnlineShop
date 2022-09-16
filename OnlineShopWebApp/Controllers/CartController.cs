using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Db;
using OnlineShopWebApp.Helpers;
using System;

namespace OnlineShopWebApp.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private readonly IProductsRepository productRepository;
        private readonly ICartsRepository cartsRepository;

        public CartController(IProductsRepository productsRepository, ICartsRepository cartsRepository)
        {
            this.productRepository = productsRepository;
            this.cartsRepository = cartsRepository;
        }

        public IActionResult Index()
        {
            var cart = cartsRepository.TryGetByUserId(Constants.UserId);
            return View(Mapping.ToCartViewModel(cart));
        }
             

        //Добавление продукта в корзину
        public IActionResult Add(Guid productId)
        {
            var product = productRepository.TryGetById(productId);
            cartsRepository.Add(product, Constants.UserId);
            return RedirectToAction("Index");
        }

        //Уменьшение кол-во товара
        public IActionResult Decrease(Guid productId)
        {
            cartsRepository.Decrease(productId, Constants.UserId);
            return RedirectToAction("Index");
        }
        public IActionResult Clear()
        {
            cartsRepository.Clear(Constants.UserId);
            return RedirectToAction("Index");
        }
    }
}