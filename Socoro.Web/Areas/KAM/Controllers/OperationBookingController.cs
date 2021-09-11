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
    public class OperationBookingController : BaseController<OperationBookingController>
    {
        HttpClient client = new HttpClient();
        string requestUri = String.Empty;
        StringContent stringContent = new StringContent("");
        string responseBody = String.Empty;
        HttpResponseMessage response = new HttpResponseMessage();
        dynamic json = new Object();

        [HttpGet]
        public async Task<IActionResult> Index(int id)
        {
            string currentOperationNo = (string)TempData["OperationNo"];

            OperationViewModel operationViewModel = new OperationViewModel
            {
                Id = id,
                OperationNo = currentOperationNo
            };
            OperationIntViewModel operationIntViewModel = new OperationIntViewModel
            {
                OperationViewModel = operationViewModel
            };
            TempData["OperationNo"] = currentOperationNo;
            return View(operationIntViewModel);
        }
    }
}
