using Microsoft.AspNetCore.Mvc;

namespace SecondProjectCore.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult ProductsPage()
        {
            return View();
        }

        public IActionResult SingleProductPage()
        {
            return View();
        }
    }
}
