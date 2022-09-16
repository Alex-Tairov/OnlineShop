using Microsoft.AspNetCore.Mvc;
using OnlineShop.Db;
using OnlineShopWebApp.Helpers;

namespace OnlineShopWebApp.Views.Components.Cart
{

    public class CartViewComponent:ViewComponent
    {
        private readonly ICartsRepository cartsRepository;
        

        public CartViewComponent(ICartsRepository cartsRepository)
        {
            this.cartsRepository = cartsRepository;
        }
        
        public IViewComponentResult Invoke()
        {
            var cart = cartsRepository.TryGetByUserId(Constants.UserId);
            var cartViewModel = Mapping.ToCartViewModel(cart);
            var productsCount = cartViewModel?.TotalCount ?? 0;
            return View("Cart", productsCount);
            
            
        }
    }
}
