using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Socoro.Web.Controllers;
using Socoro.Web.Areas.Shared.Models;
using Socoro.Application.Features.Customers.Commands.Create;
using Socoro.Application.Features.Customers.Queries.GetAllCached;

namespace Socoro.Web.Areas.Shared.Controllers
{
    [Area("Shared")]
    public class ContactController : BaseController<ContactController>
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddCustomer(int typeId)
        {
            CustomerViewModel customer = new CustomerViewModel();
            customer.TypeId = typeId;
            switch (typeId)
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
            return View(customer);
        }
        public IActionResult AddCarrier()
        {
            return View();
        }
    }
}
