using Microsoft.AspNetCore.Mvc;

namespace SecondProjectCore.Controllers
{
    public class AdminPageController : Controller
    {
        public IActionResult AdminPage()
        {
            return View();
        }
    }
}
