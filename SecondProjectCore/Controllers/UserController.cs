using Microsoft.AspNetCore.Mvc;

namespace SecondProjectCore.Controllers
{
    public class UserController : Controller
    {
        public IActionResult UserPage()
     
        {
            return View();
        }
    }
}
