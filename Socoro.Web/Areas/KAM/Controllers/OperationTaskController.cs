﻿using Microsoft.AspNetCore.Mvc;
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
        HttpClient client = new HttpClient();
        string requestUri = String.Empty;
        StringContent stringContent = new StringContent("");
        string responseBody = String.Empty;
        HttpResponseMessage response = new HttpResponseMessage();
        dynamic json = new Object();

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            OperationViewModel operationObj;

            string currentOperationNo = (string)TempData["OperationNo"];

            requestUri = Environment.GetEnvironmentVariable("ApiEndpoint") + "/Operation/2/" + currentOperationNo;
            response = await client.GetAsync(requestUri);
            responseBody = await response.Content.ReadAsStringAsync();
            JsonOperationWrapper wrapper = JsonConvert.DeserializeObject<JsonOperationWrapper>(responseBody);
            operationObj = wrapper.Data;

            
            OperationIntViewModel operationIntViewModel = new OperationIntViewModel
            {
                OperationViewModel = operationObj
            };

            TempData["OperationNo"] = currentOperationNo;
            return View(operationIntViewModel);
        }
    }
}
