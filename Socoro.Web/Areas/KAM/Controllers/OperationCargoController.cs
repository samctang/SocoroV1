using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Socoro.Web.Controllers;
using Socoro.Web.Areas.KAM.Models;
using Socoro.Application.Features.OperationCargos.Commands;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using System.Collections.Generic;

namespace Socoro.Web.Areas.KAM.Controllers
{
    [Area("KAM")]
    public class OperationCargoController : BaseController<OperationCargoController>
    {
        OperationIntViewModel operationIntViewModel = new OperationIntViewModel();

        HttpClient client = new HttpClient();
        string requestUri = String.Empty;
        StringContent stringContent = new StringContent("");
        string responseBody = String.Empty;
        HttpResponseMessage response = new HttpResponseMessage();
        dynamic json = new Object();

        // GET: OperationCargoController
        public IActionResult Index(int id)
        {
            string currentOperationNo = (string)TempData["OperationNo"];

            OperationViewModel operationViewModel = new OperationViewModel();
            operationViewModel.Id = id;
            operationViewModel.OperationNo = currentOperationNo;

            operationIntViewModel.OperationViewModel = operationViewModel;
            TempData["OperationNo"] = currentOperationNo;
            return View(operationIntViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> AddCargoAsync(int id, OperationIntViewModel operationIntViewModel)
        {
            if (ModelState.IsValid)
            {
                operationIntViewModel.OperationCargoViewModel.OperationId = id;

                var createCustomerCommand = _mapper.Map<CreateOperationCargo>(operationIntViewModel.OperationCargoViewModel);
                requestUri = Environment.GetEnvironmentVariable("ApiEndpoint") + "/OperationCargo/";
                stringContent = new StringContent(JsonConvert.SerializeObject(createCustomerCommand), Encoding.UTF8, "application/json");
                response = await client.PostAsync(requestUri, stringContent);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "Operation", new { area = "KAM" });
                }
            }
            else
                ModelState.AddModelError("Add_Customer", "Server error");
            return View(operationIntViewModel);
        }
    }
}

