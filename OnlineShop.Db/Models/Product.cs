using System;
using System.Collections.Generic;

namespace OnlineShop.Db.Models
{
    public class Product
    {
        
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }

        //Связь
        public List<CartItem> CartItems { get; set; }
        public List<Favorite> Favorite { get; set; }

        public Product()
        {
        }

        public Product(string name, int cost, string description, string imagePath) : this()
        {
            Id = Guid.NewGuid();
            Name = name;
            Cost = cost;
            Description = description;
            ImagePath = imagePath;
        }
              

    }
}
