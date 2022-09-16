using System;

namespace OnlineShop.Db.Models
{
    public class Favorite
    {
        public Guid Id { get; set; }

        //Id юзера данного списка
        public string UserId { get; set; }
        //Связь
        public Product Product { get; set; }
    }
}
