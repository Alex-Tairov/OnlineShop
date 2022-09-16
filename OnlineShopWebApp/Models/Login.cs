using System.ComponentModel.DataAnnotations;

namespace OnlineShopWebApp.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Не указан логин")]
        [StringLength(25, MinimumLength = 5, ErrorMessage = "Логин должен содержать от 5 до 25 знаков.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Не указан пароль")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        public string ReturnUrl { get; set; }
    }
}
