using OnlineShop.Db.Models;
using System;
using System.Collections.Generic;

namespace OnlineShop.Db
{
    public interface IProductsRepository
    {
        List<Product> GetAll();
        Product TryGetById(Guid id);
        void RemoveProduct(Guid productId);
        void EditProduct(Product editProduct);
        void Add(Product newProduct);
        List<Product> SearchByName(string serchWord);
    }
}