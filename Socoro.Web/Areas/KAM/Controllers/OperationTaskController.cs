using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Socoro.Web.Controllers;
using Socoro.Web.Areas.KAM.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace Socoro.Web.Areas.KAM.Controllers
{
    [Area("KAM")]
    public class OperationTaskController : BaseController<OperationTaskController>
    {
        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }
    }
}
