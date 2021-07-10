using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Socoro.Web.Controllers;
using Socoro.Web.Areas.KAM.Models;

namespace Socoro.Web.Areas.KAM.Controllers
{
    [Area("KAM")]
    public class OperationController : BaseController<OperationController>
    {
        [HttpGet]
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
