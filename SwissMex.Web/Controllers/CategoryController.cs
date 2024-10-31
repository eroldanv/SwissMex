using Microsoft.AspNetCore.Mvc;

namespace SwissMex.Web.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
