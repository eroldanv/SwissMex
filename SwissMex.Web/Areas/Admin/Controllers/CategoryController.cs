using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SwissMex.DataAccess.Data;
using SwissMex.DataAccess.Repository.IRepository;
using SwissMex.Models.Models;

namespace SwissMex.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        //private ApplicationDbContext context;
        //private readonly ICategoryRepository _categoryRepository;
        private IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            //this.context = context;
            _unitOfWork = unitOfWork;
            //this._categoryRepository = categoryRepository;
        }
        public IActionResult Index()
        {
            //var categoriesList = context.Categories.ToList();
            var categoriesList = _unitOfWork.Category.GetAll();

            return View(categoriesList);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            //Category? result = context.Categories.Find(id);

            //Category? result = context.Categories.FirstOrDefault(x => x.Id == id);
            Category? result = _unitOfWork.Category.Get(x => x.Id == id);

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
                //this.context.Categories.Update(formInput);
                //context.SaveChanges();

                _unitOfWork.Category.Update(formInput);
                _unitOfWork.Save();

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
                ModelState.AddModelError("", "El nombre no puede ser el mismo que la prioridad");
            }
            //if(formInput.Name != null && formInput.Name.ToLower() == "prueba")
            //{
            //    ModelState.AddModelError("", "En Nombre no puede ser PRUEBA");
            //}

            if (ModelState.IsValid)
            {
                //this.context.Categories.Add(formInput);
                //context.SaveChanges();

                _unitOfWork.Category.Add(formInput);
                _unitOfWork.Save();

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

            //Category? result = context.Categories.FirstOrDefault(x => x.Id == id);

            Category? result = _unitOfWork.Category.Get(x => x.Id == id);

            if (result == null)
            {
                return NotFound();

            }

            return View(result);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            //Category? category = context.Categories.FirstOrDefault(x => id == x.Id);
            Category? category = _unitOfWork.Category.Get(x => x.Id == id);

            if (category is null)
            {
                return NotFound();
            }
            //this.context.Categories.Remove(category);
            //context.SaveChanges();

            _unitOfWork.Category.Remove(category);
            _unitOfWork.Save();


            TempData["success"] = "Categoría borrada correctamente!";

            return RedirectToAction("Index");



        }

    }
}
