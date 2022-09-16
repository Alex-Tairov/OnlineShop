using System.ComponentModel.DataAnnotations;

namespace OnlineShopWebApp.Models
{
    public class Register
    {
        [Required(ErrorMessage = "Не указан логин")]
        [StringLength(25, MinimumLength = 5, ErrorMessage = "Логин должен содержать от 5 до 25 знаков")]
        public string UserName { get; set; }

        [Required]
        public string Phone { get; set; }


        [Required(ErrorMessage = "Не указан пароль")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Вы не повторили пароль")]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string ConfirmPassword { get; set; }

        public string ReturnUrl { get; set; }
    }
}
