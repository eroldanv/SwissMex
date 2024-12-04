using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SwissMex.DataAccess.Repository.IRepository;
using SwissMex.Models.Models;
using SwissMex.Models.ViewModels;
using SwissMex.Utility;

namespace SwissMex.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles = SVD.ROLE_ADMIN)]
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
            var productList = _unitOfWork.Product.GetAll(includeProperties: "Category");

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

            if (id == null || id == 0)
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
        public IActionResult Upsert(ProductVM formInput, IFormFile? file)
        {

            string wwwRootPath = _webHostEnvironment.WebRootPath;
            if (file != null)
            {
                string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                string productsPath = Path.Combine(wwwRootPath, @"images\products");

                if (!string.IsNullOrEmpty(formInput.Product.ImageUrl))
                {
                    var oldImagePath = Path.Combine(wwwRootPath, formInput.Product.ImageUrl.TrimStart('\\'));
                    if (System.IO.File.Exists(oldImagePath))
                    {
                        System.IO.File.Delete(oldImagePath);
                    }

                }

                using (var fileStream = new FileStream(Path.Combine(productsPath, fileName), FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
                formInput.Product.ImageUrl = @"\images\products\" + fileName;
                
            }            
            
            if (ModelState.IsValid)
            {
                if (formInput.Product.Id == 0)
                {
                    _unitOfWork.Product.Add(formInput.Product);
                }
                else
                {
                    _unitOfWork.Product.Update(formInput.Product);
                }

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

        #region API

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = _unitOfWork.Product.GetAll(includeProperties: "Category");

            return Json(new { data = products });

        }

        #endregion


    }
}
