using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Socoro.Web.Areas.KAM.Models
{
    public class OperationBookingMessageViewModel
    {
        public int Id { get; set; }
        public string EmployeeId { get; set; }
        public string CarrierId { get; set; }
        [Display(Name = "Additional Message")]
        public string Message { get; set; }
    }
}
