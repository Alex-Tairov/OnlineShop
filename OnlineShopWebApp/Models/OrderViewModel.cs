using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShopWebApp.Models
{
    //Содержание заказа
    public class OrderViewModel
    {
        public Guid Id { get; set; }
        public UserDeliveryInfoViewModel User { get; set; }
        public List<CartItemViewModel> Items { get; set; }
        public OrderStatusViewModel Status { get; set; }
        public DateTime CreateDateTime { get; set; }

        //Сумма заказа
        public decimal Cost
        {
            get
            {
                return Items.Sum(x => x.Cost);
            }
        }

    }
}
