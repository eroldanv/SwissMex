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

       

        [HttpPost]
        public IActionResult Create(Category formInput)
        {
            if (formInput.Name == formInput.DisplayOrder.ToString())
            {
                ModelState.AddModelError("Name", "El nombre no puede ser el mismo que la prioridad");
            }
            //if(formInput.Name != null && formInput.Name.ToLower() == "prueba")
            //{
            //    ModelState.AddModelError("", "En Nombre no puede ser PRUEBA");
            //}

            if (ModelState.IsValid)
            {
                this.context.Categories.Add(formInput);
                context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();

        }

    }
}
