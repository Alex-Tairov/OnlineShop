﻿using Microsoft.EntityFrameworkCore;
using OnlineShop.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShop.Db
{
    public class CartsDbRepository : ICartsRepository
    {
        private readonly DatabaseContext databaseContext;

        public CartsDbRepository(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        //Поиск корзины пользователя
        public Cart TryGetByUserId(string userId)
        {
            return databaseContext.Carts.Include(x => x.Items).ThenInclude(x => x.Product).FirstOrDefault(x => x.UserId == userId);
        }

        public void Decrease(Guid productId, string userId)
        {
            var existingCart = TryGetByUserId(userId);
            var existingCartItem = existingCart?.Items?.FirstOrDefault(x => x.Product.Id == productId);
            if (existingCartItem == null)
            {
                return;
            }

            existingCartItem.Amount -= 1;

            if (existingCartItem.Amount == 0)
            {
                existingCart.Items.Remove(existingCartItem);
            }
            databaseContext.SaveChanges();
            databaseContext.SaveChanges();

        }
        public void Clear(string userId)
        {
            var cart = TryGetByUserId(userId);
            databaseContext.Carts.Remove(cart);
            databaseContext.SaveChanges();
        }


        public void Add(Product product, string userId)
        {
            var existingCart = TryGetByUserId(userId);
            //Если корзины нет,то создаем ее
            if (existingCart == null)
            {
                var newCart = new Cart
                {
                    UserId = userId
                };

                newCart.Items = new List<CartItem>
                    {
                        new CartItem
                        {
                            Amount = 1,
                            Product = product,
                        }
                    };
                databaseContext.Carts.Add(newCart);
            }
            else
            {
                var existingCartItem = existingCart.Items.FirstOrDefault(x => x.Product.Id == product.Id);
                if (existingCartItem != null)
                {
                    existingCartItem.Amount += 1;
                }
                else
                {
                    existingCart.Items.Add(new CartItem
                    {
                        Amount = 1,
                        Product = product,
                    });
                }
            }
            databaseContext.SaveChanges();
        }
    }
}