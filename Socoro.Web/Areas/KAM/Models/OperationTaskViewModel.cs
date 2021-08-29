using System;
using System.ComponentModel.DataAnnotations;

namespace Socoro.Web.Areas.KAM.Models
{
    public class OperationTaskViewModel
    {
        public int Id { get; set; }
        public string Note { get; set; }
        [Display(Name = "Due Date")]
        public DateTime? DueDate { get; set; }
        public bool Status { get; set; }
        public int OperationProcessId { get; set; }
    }
}
