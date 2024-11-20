using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
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

        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
           
            //Category? result = context.Categories.Find(id);
            Category? result = context.Categories.FirstOrDefault(x => x.Id == id);
            //Category? result2 = context.Categories.Where(x => x.Id == id).FirstOrDefault();
            //Category? result3 = context.Categories.First(x => x.Id == id);

            if (result == null)
            {
                return NotFound();
                
            }

            

            return View(result);
        }

        [HttpPost]
        public IActionResult Edit(Category formInput)
        {           
            if (ModelState.IsValid)
            {
                this.context.Categories.Update(formInput);
                context.SaveChanges();
                
                TempData["success"] = "Categoría actualizada correctamente!";
                return RedirectToAction("Index");
            }

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

                TempData["success"] = "Categoría agregada correctamente!";
                return RedirectToAction("Index");
            }


            return View();

        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
           
            Category? result = context.Categories.FirstOrDefault(x => x.Id == id);
           
            if (result == null)
            {
                return NotFound();

            }

            return View(result);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Category? category = context.Categories.FirstOrDefault(x => id == x.Id);

            if (category is null)
            {
                return NotFound();
            }
                this.context.Categories.Remove(category);
                context.SaveChanges();


            TempData["success"] = "Categoría borrada correctamente!";

            return RedirectToAction("Index");            

            

        }

    }
}
