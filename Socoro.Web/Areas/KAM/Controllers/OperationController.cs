using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Socoro.Web.Controllers;
using Socoro.Web.Areas.KAM.Models;
using Socoro.Application.Features.Operations.Commands;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using Socoro.Application.Features.OperationProcesses.Commands;

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
        public async Task<IActionResult> IndexAsync(OperationViewModel operationViewModel)
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
                requestUri = Environment.GetEnvironmentVariable("ApiEndpoint") + "/operation";
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
        [HttpGet]
        public async Task<IActionResult> OperationProcessAsync()
        {
            OperationViewModel operationObj = new OperationViewModel();
            OperationProcessViewModel operationProcessObj = new OperationProcessViewModel();

            string currentOperationNo = (string)TempData["OperationNo"];

            requestUri = Environment.GetEnvironmentVariable("ApiEndpoint") + "/Operation/2/" + currentOperationNo;
            response = await client.GetAsync(requestUri);
            responseBody = await response.Content.ReadAsStringAsync();
            Wrapper wrapper = JsonConvert.DeserializeObject<Wrapper>(responseBody);
            operationObj = wrapper.data;

            requestUri = Environment.GetEnvironmentVariable("ApiEndpoint") + "/OperationProcess/" + operationObj.Id;
            response = await client.GetAsync(requestUri);
            responseBody = await response.Content.ReadAsStringAsync();
            json = JsonConvert.DeserializeObject(responseBody);
            if (json.data.Count == 0)
            {
                requestUri = Environment.GetEnvironmentVariable("ApiEndpoint") + "/operationProcessType/1/" + operationObj.TypeId;
                response = await client.GetAsync(requestUri);
                responseBody = await response.Content.ReadAsStringAsync();
                json = JsonConvert.DeserializeObject(responseBody);
                foreach (var item in json.data)
                {
                    operationProcessObj.TypeId = item.id;
                    operationProcessObj.Status = "In Progress";
                    operationProcessObj.OperationId = operationObj.Id;

                    operationObj.OperationProcesses.Add(operationProcessObj);

                    var createOperationProcessCommand = _mapper.Map<CreateOperationProcess>(operationProcessObj);
                    requestUri = Environment.GetEnvironmentVariable("ApiEndpoint") + "/operationProcess";
                    stringContent = new StringContent(JsonConvert.SerializeObject(createOperationProcessCommand), Encoding.UTF8, "application/json");
                    response = await client.PostAsync(requestUri, stringContent);
                }
            }
            return View(operationObj);

        }
        [HttpPost]
        public IActionResult GetOperationDetails([FromBody] string operationNo)
        {
            TempData.Remove("OperationNo");
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

            requestUri = Environment.GetEnvironmentVariable("ApiEndpoint") + "/operation?typeId=" + operationViewModel.TypeId;
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
    public class Wrapper
    {
        public Data data { get; set; }
        public string message { get; set; }
        public bool failed { get; set; }
        public bool succeeded { get; set; }
    }
    public class Data : OperationViewModel
    {
        
    }
}
