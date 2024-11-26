using Microsoft.AspNetCore.Mvc;
using SwissMex.DataAccess.Repository.IRepository;
using SwissMex.Models.Models;

namespace SwissMex.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private IUnitOfWork _unitOfWork;

        public ProductController(IUnitOfWork unitOfWork)
        {
            //this.context = context;
            _unitOfWork = unitOfWork;
            //this._categoryRepository = categoryRepository;
        }

        public IActionResult Index()
        {
            var productList = _unitOfWork.Product.GetAll();

            return View(productList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product formInput)
        {            
            if (ModelState.IsValid)
            {
               
                _unitOfWork.Product.Add(formInput);
                _unitOfWork.Save();

                TempData["success"] = "Producto agregado correctamente!";
                return RedirectToAction("Index");
            }


            return View();

        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
           
            Product? result = _unitOfWork.Product.Get(x => x.Id == id);
          
            if (result == null)
            {
                return NotFound();

            }
            return View(result);
        }

        [HttpPost]
        public IActionResult Edit(Product formInput)
        {
            if (ModelState.IsValid)
            {
               
                _unitOfWork.Product.Update(formInput);
                _unitOfWork.Save();

                TempData["success"] = "Producto actualizado correctamente!";
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
            Product? result = _unitOfWork.Product.Get(x => x.Id == id);

            if (result == null)
            {
                return NotFound();

            }

            return View(result);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
          
            Product? product = _unitOfWork.Product.Get(x => x.Id == id);

            if (product is null)
            {
                return NotFound();
            }
          
            _unitOfWork.Product.Remove(product);
            _unitOfWork.Save();


            TempData["success"] = "Producto borrado correctamente!";

            return RedirectToAction("Index");



        }


    }
}
