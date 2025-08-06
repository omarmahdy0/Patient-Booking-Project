using Microsoft.AspNetCore.Mvc;
using LoginApp.Models;

namespace LoginApp.Controllers
{
    public class AccountController : Controller
    {
        // GET: /Account/Login
        public IActionResult Login()
        {
            return View(new User());
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            if (user.Username == "admin" && user.Password == "123")
            {
                ViewBag.Message = "Login successful!";
            }
            else
            {
                ViewBag.Message = "Invalid credentials.";
            }

            return View();
        }
    }
}
