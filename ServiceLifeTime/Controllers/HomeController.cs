using Microsoft.AspNetCore.Mvc;
using ServiceLifeTime.Models;
using ServiceLifeTime.Services;
using System.Diagnostics;
using System.Text;

namespace ServiceLifeTime.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITransientGUIDService _transient1;
        private readonly ITransientGUIDService _transient2;
        private readonly IScopedGUIDService _scoped1;
        private readonly IScopedGUIDService _scoped2;
        private readonly ISingletonGUIDService _singleton1;
        private readonly ISingletonGUIDService _singleton2;

        public HomeController(ITransientGUIDService transient1, ITransientGUIDService transient2,
                              IScopedGUIDService scoped1, IScopedGUIDService scoped2,
                              ISingletonGUIDService singleton1, ISingletonGUIDService singleton2)
        {
            this._transient1 = transient1;
            this._transient2 = transient2;

            this._scoped1 = scoped1;
            this._scoped2 = scoped2;

            this._singleton1 = singleton1;
            this._singleton2 = singleton2;

        }

        public IActionResult Index()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append($"Transient 1: { _transient1.GetGuid() }\n");
            builder.Append($"Transient 2: {_transient2.GetGuid()}\n\n");
            builder.Append($"Scoped 1: {_scoped1.GetGuid()}\n");
            builder.Append($"Scoped 2: {_scoped2.GetGuid()}\n\n");
            builder.Append($"Singleton 1: {_singleton1.GetGuid()}\n");
            builder.Append($"Singleton 2: {_singleton2.GetGuid()}\n");


            return Ok(builder.ToString());
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
