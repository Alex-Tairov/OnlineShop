using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Db;
using OnlineShopWebApp.Helpers;
using System;

namespace OnlineShopWebApp.Controllers
{
    [Authorize]
    public class FavoriteController : Controller
    {
        private readonly IFavoritesRepository favoritesRepository;
        private readonly IProductsRepository productRepository;

        public FavoriteController(IFavoritesRepository favoritesRepository, IProductsRepository productRepository)
        {
            this.favoritesRepository = favoritesRepository;
            this.productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var favouritesProducts = favoritesRepository.GetAll(Constants.UserId);
            return View(Mapping.ToProductsViewModels(favouritesProducts));
        }

        public IActionResult Add(Guid productId)
        {
            var product = productRepository.TryGetById(productId);
            favoritesRepository.Add(product,Constants.UserId);
            return RedirectToAction("Index");
        }
        public IActionResult Remove(Guid productId)
        {
            favoritesRepository.Remove(productId, Constants.UserId);
            return RedirectToAction("Index");
        }
        public IActionResult Clear()
        {
            favoritesRepository.Clear(Constants.UserId);
            return RedirectToAction("Index");
        }
    }
}
