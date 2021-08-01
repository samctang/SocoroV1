using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Socoro.Web.Controllers;
using Socoro.Web.Areas.KAM.Models;
using Socoro.Application.Features.Operations.Commands;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;

namespace Socoro.Web.Areas.KAM.Controllers
{
    [Area("KAM")]
    public class OperationController : BaseController<OperationController>
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
            OperationViewModel operationViewModel = new OperationViewModel();
            operationViewModel.CompanyId = 1;
            //Add other default values
            return View(operationViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Create(OperationViewModel operationViewModel)
        {
            if (ModelState.IsValid)
            {
                operationViewModel.CompanyId = 1;
                operationViewModel.EmployeeId = 3;
                operationViewModel.Progress = 0;
                operationViewModel.Status = "In Progress";
                operationViewModel.SubmittedDate = DateTime.Now;
                await GetOperationNumberAsync(operationViewModel);

                var createOperationCommand = _mapper.Map<CreateOperation>(operationViewModel);
                requestUri = Environment.GetEnvironmentVariable("ApiEndpoint") + "/operation/";
                stringContent = new StringContent(JsonConvert.SerializeObject(createOperationCommand), Encoding.UTF8, "application/json");
                response = await client.PostAsync(requestUri, stringContent);

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "Operation", new { area = "KAM" });
                }
            }
            else
                ModelState.AddModelError("Add_Operation", "Server error");
            return View(operationViewModel);
        }
        [HttpPost]
        public IActionResult GetOperationDetails([FromBody] string operationNo)
        {
            TempData["OperationNo"] = operationNo;
            return Json("success");
        }
        private async Task GetOperationNumberAsync(OperationViewModel operationViewModel)
        {
            string operationString = String.Empty;
            string operationNum = "00000000";

            requestUri = Environment.GetEnvironmentVariable("ApiEndpoint") + "/operationType/" + operationViewModel.TypeId;
            response = await client.GetAsync(requestUri);
            responseBody = await response.Content.ReadAsStringAsync();
            json = JsonConvert.DeserializeObject(responseBody);
            string freight = json.data.freight;
            switch (freight)
            {
                case "Ocean":
                    operationString += "O";
                    break;
                case "Air":
                    operationString += "A";
                    break;
                case "Land":
                    operationString += "L";
                    break;
            }

            requestUri = Environment.GetEnvironmentVariable("ApiEndpoint") + "/operation/3/" + operationViewModel.TypeId;
            response = await client.GetAsync(requestUri);
            responseBody = await response.Content.ReadAsStringAsync();
            json = JsonConvert.DeserializeObject(responseBody);
            if (json.data != null)
            {
                string jsonStringVal = json.data.operationNo;
                operationNum = (Convert.ToInt32(jsonStringVal.Substring(3, 8)) + 1).ToString("00000000");
            }
            operationString += operationViewModel.TypeId.ToString("00") + operationNum;
            operationViewModel.OperationNo = operationString;
        }
    }
}
