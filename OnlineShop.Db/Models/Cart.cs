using System;
using System.Collections.Generic;

namespace OnlineShop.Db.Models
{
    public class Cart
    {
        public Guid Id { get; set; }

        //Id юзера данной корзины
        public string UserId { get; set; }

        //Связь
        public List<CartItem> Items { get; set; }

        public DateTime CreatedDateTime { get; set; }
        public Cart()
        {
            CreatedDateTime = DateTime.Now;
        }
    }
}