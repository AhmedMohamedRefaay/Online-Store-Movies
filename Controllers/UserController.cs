using Microsoft.AspNetCore.Mvc;
using Online__Store_Movies.Models.DTO;
using Online__Store_Movies.Repository.Abstract;

namespace Online__Store_Movies.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserAuthntication _userAuthntication;

        public UserController(IUserAuthntication userAuthntication)
        {
            _userAuthntication = userAuthntication;
        }
        public async Task<IActionResult> Register()
        {
            var model = new RegistrationModel
            {
                Email = "Admin@gmail.com",
                Name = "Ahmed",
                Username = "Admin",
                Password = "Admin@123",
                PasswordConfirm = "Admin@123",
                Role = "Admin"
            };
            var message = await _userAuthntication.RegisterAsync(model);
            return Ok(message.Message);
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var result = await _userAuthntication.LoginAsync(model);
            if (result.StatusCode == 1)
                return RedirectToAction("Index", "Home");
            else
            {
                TempData["msg"] = "Could not logged in..";
                return RedirectToAction(nameof(Login));
            }
        }

        public async Task<IActionResult> Logout()
        {
            await _userAuthntication.LogoutAsync();
            return RedirectToAction(nameof(Login));
        }
    }
    }

