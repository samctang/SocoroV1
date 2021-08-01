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
    public class OperationCargoController : BaseController<OperationCargoController>
    {
        // GET: OperationCargoController
        public ActionResult Index()
        {
            OperationViewModel operationViewModel = new OperationViewModel();
            operationViewModel.OperationNo = "0000";
            OperationIntViewModel operationIntViewModel = new OperationIntViewModel();
            operationIntViewModel.OperationViewModel = operationViewModel;
            return View(operationIntViewModel);
        }

    }
}
