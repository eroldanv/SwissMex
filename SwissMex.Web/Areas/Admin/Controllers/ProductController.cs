using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SwissMex.DataAccess.Repository.IRepository;
using SwissMex.Models.Models;
using SwissMex.Models.ViewModels;

namespace SwissMex.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private IUnitOfWork _unitOfWork;
        private IWebHostEnvironment _webHostEnvironment;

        public ProductController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            //this.context = context;
            _unitOfWork = unitOfWork;
            this._webHostEnvironment = webHostEnvironment;
            //this._categoryRepository = categoryRepository;
        }

        public IActionResult Index()
        {
            var productList = _unitOfWork.Product.GetAll();

            return View(productList);
        }

        public IActionResult Upsert(int? id)
        {
            IEnumerable<SelectListItem> CategoryList = _unitOfWork.Category.GetAll().Select(c =>
                new SelectListItem { Value = c.Id.ToString(), Text = c.Name }
            );

            ProductVM productVM = new ProductVM
            {
                CategoryList = CategoryList,
                Product = new Product()
            };

            if(id == null || id == 0)
            {
                return View(productVM);
            }
            else
            {
                productVM.Product = _unitOfWork.Product.Get(x => x.Id == id)!;
            }

            //ViewBag.CategoryList = CategoryList;
            //ViewData["CategoryList"] = CategoryList;

            return View(productVM);
        }

        [HttpPost]
        public IActionResult Upsert(ProductVM formInput,IFormFile? file)
        {            
            if (ModelState.IsValid)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                if(file != null)
                {
                    string filenName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    string productPath = Path.Combine(wwwRootPath, @"images\products");
                    using (var fileStream = new FileStream(Path.Combine(productPath, filenName), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    formInput.Product.ImageUrl = @"\images\products\"+filenName;

                }

                _unitOfWork.Product.Add(formInput.Product);
                _unitOfWork.Save();

                TempData["success"] = "Producto agregado correctamente!";
                return RedirectToAction("Index");
            }
            else
            {
                IEnumerable<SelectListItem> CategoryList = _unitOfWork.Category.GetAll().Select(c =>
                    new SelectListItem { Value = c.Id.ToString(), Text = c.Name }
                );

                formInput.CategoryList = CategoryList;
            }

            return View(formInput);

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
