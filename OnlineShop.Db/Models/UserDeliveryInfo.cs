using System;

namespace OnlineShop.Db.Models
{
    //Данные человека,делающего заказ
    public class UserDeliveryInfo
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
