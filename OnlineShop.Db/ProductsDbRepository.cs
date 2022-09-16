using OnlineShop.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShop.Db
{
    public class ProductsDbRepository : IProductsRepository
    {
        private readonly DatabaseContext databaseContext;

        public ProductsDbRepository(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        public List<Product> GetAll()
        {
            return databaseContext.Products.ToList();
        }

        public Product TryGetById(Guid id)
        {
            return databaseContext.Products.FirstOrDefault(product => product.Id == id);
        }
        public void RemoveProduct(Guid productId)
        {
            var removedProduct = databaseContext.Products.FirstOrDefault(product => product.Id == productId);
            databaseContext.Products.Remove(removedProduct);
            databaseContext.SaveChanges();
        }
        public void EditProduct(Product editProduct)
        {
            var product = TryGetById(editProduct.Id);
            product.Name = editProduct.Name;
            product.Cost = editProduct.Cost;
            product.Description = editProduct.Description;
            databaseContext.SaveChanges();
        }

        public void Add(Product newProduct)
        {
            newProduct.ImagePath = "/images/1.jpg";
            databaseContext.Products.Add(newProduct);
            databaseContext.SaveChanges();
        }

        public List<Product> SearchByName(string serchWord)
        {
            return databaseContext.Products.Where(product => product.Name.ToLower().Contains(serchWord.ToLower())).ToList();
        }



    }
}
