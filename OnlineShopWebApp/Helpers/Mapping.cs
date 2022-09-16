using OnlineShop.Db.Models;
using OnlineShopWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopWebApp.Helpers
{
    public static class Mapping
    {
        public static List<ProductViewModel> ToProductsViewModels(List<Product> products)
        {
            var productsViewModels = new List<ProductViewModel>();
            foreach (var product in products)
            {
                var productViewModel = ToProductViewModel(product);
                productsViewModels.Add(productViewModel);
            }
            return productsViewModels;
        }

        public static ProductViewModel ToProductViewModel(Product product)
        {
            var productViewModel = new ProductViewModel
            {
                Id = product.Id,
                Name = product.Name,
                Cost = product.Cost,
                Description = product.Description,
                ImagePath = product.ImagePath
            };
            return productViewModel;
        }
        public static Product ToProductDb(ProductViewModel product)
        {
            var productDb = new Product
            {
                Id=product.Id,
                Name = product.Name,
                Cost = product.Cost,
                Description = product.Description,
                ImagePath = product.ImagePath
            };
            return productDb;
        }

        public static List<CartItemViewModel> ToCartItemsViewModels(List<CartItem> cartItems)
        {
            var cartItemsViewModels = new List<CartItemViewModel>();
            foreach (var cartItem in cartItems)
            {
                var carItemViewModel = ToCartItemViewModel(cartItem);
                cartItemsViewModels.Add(carItemViewModel);
            }
            return cartItemsViewModels;
        }
        public static CartItemViewModel ToCartItemViewModel(CartItem cartItem)
        {
            var cartItemViewModel = new CartItemViewModel
            {
                Id = cartItem.Id,
                Amount = cartItem.Amount,
                Product = ToProductViewModel(cartItem.Product)
            };
            return cartItemViewModel;
        }
        public static CartViewModel ToCartViewModel(Cart cart)
        {
            if (cart == null)
                return null;
            var cartViewModel = new CartViewModel
            {
                Id = cart.Id,
                UserId = cart.UserId,
                Items = ToCartItemsViewModels(cart.Items)
            };
            return cartViewModel;
        }

        public static OrderViewModel ToOrderViewModel(this Order order)
        {
            return new OrderViewModel
            {
                Id = order.Id,
                CreateDateTime = order.CreateDateTime,
                Status = (OrderStatusViewModel)(int)order.Status,
                User = ToUserDeliveryInfoViewModel(order.User),
                Items = ToCartItemsViewModels(order.Items)
            };
        }

        public static UserDeliveryInfoViewModel ToUserDeliveryInfoViewModel(this UserDeliveryInfo deliveryInfo)
        {
            return new UserDeliveryInfoViewModel
            {
                Name = deliveryInfo.Name,
                Address = deliveryInfo.Address,
                Phone = deliveryInfo.Phone
            };
        }

        public static UserDeliveryInfo ToUser(this UserDeliveryInfoViewModel user)
        {
            return new UserDeliveryInfo
            {
                Name = user.Name,
                Address = user.Address,
                Phone = user.Phone
            };
        }

        public static UserViewModel ToUserViewModel(this User user)
        {
            return new UserViewModel
            {
                Name = user.UserName,
                Phone = user.PhoneNumber
            };
        }
    }
}
