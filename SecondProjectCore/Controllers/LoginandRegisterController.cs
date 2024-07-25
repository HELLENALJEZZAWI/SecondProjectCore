using Microsoft.AspNetCore.Mvc;

namespace SecondProjectCore.Controllers
{
    public class LoginandRegisterController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
    
    }
}
