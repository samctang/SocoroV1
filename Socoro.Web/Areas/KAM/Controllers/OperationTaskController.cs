using Microsoft.AspNetCore.Mvc;
using System;
using Socoro.Web.Controllers;
using System.Net.Http;

namespace Socoro.Web.Areas.KAM.Controllers
{
    [Area("KAM")]
    public class OperationTaskController : BaseController<OperationTaskController>
    {
        HttpClient client = new HttpClient();
        string requestUri = String.Empty;
        StringContent stringContent = new StringContent("");
        string responseBody = String.Empty;
        HttpResponseMessage response = new HttpResponseMessage();
        dynamic json = new Object();

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
