using System;

namespace OnlineShop.Db.Models
{
    //Позиция в корзине одного конкретного товара
    public class CartItem
    {
        public Guid Id { get; set; }

        //Связь
        public Product Product { get; set; }
                
        public int Amount { get; set; }
    }
}