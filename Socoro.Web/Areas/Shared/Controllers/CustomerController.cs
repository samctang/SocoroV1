﻿using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Socoro.Web.Controllers;
using Socoro.Web.Areas.Shared.Models;
using Socoro.Application.Features.Customers.Commands;
using System.Net.Http;
using System;
using Newtonsoft.Json;
using System.Text;

namespace Socoro.Web.Areas.Shared.Controllers
{
    [Area("Shared")]
    public class CustomerController : BaseController<CustomerController>
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddCustomer(int id)
        {
            CustomerViewModel customerViewModel = new CustomerViewModel();
            //Add default values
            ViewBag.TypeId = id;
            switch (id)
            {
                case 1:
                    ViewBag.Title = "Add Agent";
                    ViewBag.Customer = "Agent";
                    break;
                case 2:
                    ViewBag.Title = "Add Shipper";
                    ViewBag.Customer = "Shipper";
                    break;
                case 3:
                    ViewBag.Title = "Add Consignee";
                    ViewBag.Customer = "Consignee";
                    break;
                default:
                    ViewBag.Title = "Add Customer";
                    ViewBag.Customer = "Customer";
                    break;
            }
            return View(customerViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> AddCustomerAsync(int id, CustomerViewModel customerViewModel)
        {
            if (ModelState.IsValid)
            {
                customerViewModel.CompanyId = 1;
                customerViewModel.TypeId = id;
                var createCustomerCommand = _mapper.Map<CreateCustomer>(customerViewModel);
                using var client = new HttpClient();
                string requestUri = Environment.GetEnvironmentVariable("ApiEndpoint") + "/customer";
                var stringContent = new StringContent(JsonConvert.SerializeObject(createCustomerCommand), Encoding.UTF8, "application/json");
                var response = await client.PostAsync(requestUri, stringContent);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "Operation", new { area = "KAM" });
                }
            }
            else
                ModelState.AddModelError("Add_Customer", "Server error");
            return View(customerViewModel);
        }
    }
}