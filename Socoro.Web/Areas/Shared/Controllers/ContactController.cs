using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Socoro.Web.Controllers;
using Socoro.Web.Areas.Shared.Models;

namespace Socoro.Web.Areas.Shared.Controllers
{
    [Area("Shared")]
    public class ContactController : BaseController<ContactController>
    {
        //private readonly CustomerModel objCustomerModel;
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddCustomer(int typeId)
        {
            ViewBag.TypeId = typeId;
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

           // objCustomerViewModel.TypeId = typeId;
            return View();
        }
        public IActionResult AddCarrier()
        {
            return View();
        }
    }
}
