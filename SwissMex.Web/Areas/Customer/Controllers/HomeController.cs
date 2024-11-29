using Microsoft.AspNetCore.Mvc;
using SwissMex.DataAccess.Repository;
using SwissMex.DataAccess.Repository.IRepository;
using SwissMex.Models.Models;
using System.Diagnostics;

namespace SwissMex.Web.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly IUnitOfWork UnitOfWork;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
            _logger = logger;
        }

        public IActionResult Index()
        {

            IEnumerable<Product> productList = this.UnitOfWork.Product.GetAll(includeProperties: "Category");

            return View(productList);

        }

        public IActionResult Details(int productId)
        {

            var product = UnitOfWork.Product.Get(x => x.Id == productId, includeProperties: "Category");



            return View(product);

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
