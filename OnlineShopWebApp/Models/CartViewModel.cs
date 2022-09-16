using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShopWebApp
{
    public class CartViewModel
    {
        public Guid Id { get; set; }
        
        //Id юзера данной корзины
        public string UserId { get; set; }
        public List<CartItemViewModel> Items { get; set; }

        //Сумма всех покупок
        public decimal Cost
        {
            get
            {
                return Items.Sum(x => x.Cost);
            }
        }

        //Количество всех товаров в корзине
        public int TotalCount
        {
            get
            {
                return Items?.Sum(x => x.Amount)??0;
            }
            
        }
    }
}