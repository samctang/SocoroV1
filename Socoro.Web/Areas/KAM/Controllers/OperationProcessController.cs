using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Socoro.Web.Controllers;
using Socoro.Web.Areas.KAM.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using Socoro.Application.Features.OperationProcesses.Commands;

namespace Socoro.Web.Areas.KAM.Controllers
{
    [Area("KAM")]
    public class OperationProcessController : BaseController<OperationProcessController>
    {
        HttpClient client = new HttpClient();
        string requestUri = String.Empty;
        StringContent stringContent = new StringContent("");
        string responseBody = String.Empty;
        HttpResponseMessage response = new HttpResponseMessage();
        dynamic json = new Object();

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            OperationViewModel operationObj = new OperationViewModel();
            OperationProcessViewModel operationProcessObj = new OperationProcessViewModel();

            string currentOperationNo = (string)TempData["OperationNo"];
            TempData.Remove("OperationNo");

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
            TempData["OperationNo"] = currentOperationNo;
            return View(operationObj);
        }
    }
}
