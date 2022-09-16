using System.ComponentModel.DataAnnotations;

namespace OnlineShopWebApp.Models
{
    //Данные человека,делающего заказ
    public class UserDeliveryInfoViewModel
    {
        [Required(ErrorMessage = "Не указано имя")]
        [StringLength(60, MinimumLength = 5, ErrorMessage = "Имя должен содержать от 5 до 60 знаков.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Не указан адрес доставки")]
        [StringLength(60, MinimumLength = 5, ErrorMessage = "Адрес должен содержать от 10 до 80 знаков.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Не указан телефон")]
        [RegularExpression(@"\d{1}-\d{3}-\d{3}-\d{4}$", ErrorMessage = "Формат телефона: 8-888-888-8888")]
        public string Phone { get; set; }
    }
}
