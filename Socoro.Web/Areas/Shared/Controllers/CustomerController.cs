using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Socoro.Web.Controllers;
using Socoro.Web.Areas.Shared.Models;
using Socoro.Application.Features.Customers.Commands.Create;

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
            return View("AddCustomer", customerViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> AddCustomer(int id, CustomerViewModel customerViewModel)
        {
            if (ModelState.IsValid)
            {
                customerViewModel.TypeId = id;
                var createCustomerCommand = _mapper.Map<CreateCustomerCommand>(customerViewModel);
                var result = await _mediator.Send(createCustomerCommand);
                if (result.Succeeded)
                {
                    _notify.Success($"Customer with ID {result.Data} Created.");
                    return RedirectToAction("Index", "Operation", new { area = "KAM" });
                }
                else
                {
                    _notify.Error(result.Message);
                    return RedirectToAction("AddOperation", "Operation", new { area = "KAM", id = customerViewModel.TypeId });
                }
            }
            else
            {
                return RedirectToAction("Index", "Operation", new { area = "KAM" });
            }
        }
    }
}
