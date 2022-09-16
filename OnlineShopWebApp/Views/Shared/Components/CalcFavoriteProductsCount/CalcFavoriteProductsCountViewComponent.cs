using Microsoft.AspNetCore.Mvc;
using OnlineShop.Db;

namespace OnlineShopWebApp.Views.Shared.Components.CartViewComponents
{
    public class CalcFavoriteProductsCountViewComponent : ViewComponent
    {
        private readonly IFavoritesRepository favoritesRepository;

        public CalcFavoriteProductsCountViewComponent(IFavoritesRepository favoritesRepository)
        {
            this.favoritesRepository = favoritesRepository;
        }

        public IViewComponentResult Invoke()
        {
            var productsCount = favoritesRepository.GetAll(Constants.UserId).Count;

            return View("FavoriteProductsCountView", productsCount);
        }

    }
}