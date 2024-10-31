using Microsoft.AspNetCore.Mvc;
using SwissMex.Web.Data;
using SwissMex.Web.Models;

namespace SwissMex.Web.Controllers
{
    public class CategoryController : Controller
    {
        private ApplicationDbContext context;
        public CategoryController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            List<Category> categoriesList = context.Categories.ToList();
            return View(categoriesList);
        }
    }
}
