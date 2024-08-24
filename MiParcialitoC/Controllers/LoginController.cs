using Microsoft.AspNetCore.Mvc;

namespace MiParcialitoC.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string email, string password, bool rememberMe)
        {
            return RedirectToAction("Index", "Login");
        }
    }
}
