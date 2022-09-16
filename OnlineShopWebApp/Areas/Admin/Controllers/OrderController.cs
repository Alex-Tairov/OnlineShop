using Microsoft.AspNetCore.Mvc;
using OnlineShop.Db;
using OnlineShop.Db.Models;
using OnlineShopWebApp.Helpers;
using OnlineShopWebApp.Models;
using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace OnlineShopWebApp.Areas.Admin.Controllers
{
    [Area(Constants.AdminRoleName)]
    [Authorize(Roles = Constants.AdminRoleName)]
    public class OrderController : Controller
    {
        private readonly IOrdersRepository ordersRepository;
        
        public OrderController(IOrdersRepository ordersRepository)
        {
            this.ordersRepository = ordersRepository;
        }
        public IActionResult Index()
        {
            var orders = ordersRepository.GetAll();
            return View(orders.Select(x => x.ToOrderViewModel()).ToList());
        }

        public IActionResult Detail(Guid orderId)
        {
            var order = ordersRepository.TryGetById(orderId);
            return View(order.ToOrderViewModel());
        }
        public IActionResult UpdateStatus(Guid orderId, OrderStatusViewModel status)
        {
            ordersRepository.UpdateStatus(orderId, (OrderStatus)(int)status);
            return RedirectToAction(nameof(Index));
        }
               
    }
}
