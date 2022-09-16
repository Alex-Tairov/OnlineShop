using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;
using OnlineShop.Db.Models;

namespace OnlineShopWebApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Login(string returnUrl)
        {
            return View(new Login() { ReturnUrl = returnUrl });
        }
        [HttpPost]
        public IActionResult Login(Login login)
        {
            if (ModelState.IsValid)
            {
                var result = _signInManager.PasswordSignInAsync(login.UserName, login.Password, login.RememberMe, false).Result;
                if (result.Succeeded)
                {
                    return SuccessfulCompletion(login.ReturnUrl);
                }
                else
                {
                    ModelState.AddModelError("", "Логин или пароль неверный. Попробуйте еще раз.");
                }
            }
            return View("Login", login);
        }
        public IActionResult Register(string returnUrl)
        {
            return View(new Register() { ReturnUrl = returnUrl });
        }
        [HttpPost]
        public IActionResult Register(Register register)
        {
            if (ModelState.IsValid)
            {
                User user = new User { Email = register.UserName, UserName = register.UserName, PhoneNumber = register.Phone };
                // добавляем пользователя
                var result = _userManager.CreateAsync(user, register.Password).Result;
                if (result.Succeeded)
                {
                    // установка куки
                    _signInManager.SignInAsync(user, false).Wait();
                    return SuccessfulCompletion(register.ReturnUrl);
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View("Register", register);
        }
        public IActionResult Logout()
        {
            _signInManager.SignOutAsync().Wait();
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }
        private IActionResult SuccessfulCompletion(string returnUrl)
        {
            if (returnUrl == null)
                return RedirectToAction("Index", "Home");
            else
                return Redirect(returnUrl);
        }
    }
}
