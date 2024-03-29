﻿using OnlineShopWebApp.Models;
using System;

namespace OnlineShopWebApp
{
    //Позиция в корзине одного конкретного товара
    public class CartItemViewModel
    {
        public Guid Id { get; set; }
        public ProductViewModel Product { get; set; }

        public int Amount { get; set; }

        public decimal Cost
        {
            get
            {
                return Product.Cost * Amount;
            }
        }
               

    }
}