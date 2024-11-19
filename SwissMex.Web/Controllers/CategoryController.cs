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
            var categoriesList = context.Categories.ToList();
            
            return View(categoriesList);
        }

        public IActionResult Create()
        {

            return View();
        }
    }
}
