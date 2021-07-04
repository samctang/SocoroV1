using Socoro.Web.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Socoro.Web.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class HomeController : BaseController<HomeController>
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}