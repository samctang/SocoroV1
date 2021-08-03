using Microsoft.AspNetCore.Mvc;
using Socoro.Web.Controllers;
using Socoro.Web.Areas.KAM.Models;

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
