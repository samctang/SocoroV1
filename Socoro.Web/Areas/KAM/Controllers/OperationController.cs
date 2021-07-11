using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Socoro.Web.Controllers;
using Socoro.Web.Areas.KAM.Models;
using Socoro.Application.Features.Operations.Commands.Create;
using Socoro.Application.Features.Operations.Queries.GetAllCached;

namespace Socoro.Web.Areas.KAM.Controllers
{
    [Area("KAM")]
    public class OperationController : BaseController<OperationController>
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
