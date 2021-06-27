using System;
using System.ComponentModel.DataAnnotations;

namespace Socoro.Web.ViewModels
{
    public class OperationView
    {
        public int Id { get; set; }
        public int OperationId { get; set; }
        public int ProcessId { get; set; }
        public string Status { get; set; }
        public DateTime? CompletionDate { get; set; }
    }
}
