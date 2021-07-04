using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Socoro.Web.Controllers
{
    [Area("KAM")]
    public class HomeController : BaseController<HomeController>
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ViewOperation()
        {
            return View();
        }
    }
}
