using System;

namespace Socoro.Application.DTOs.Operation
{
    public class OperationTaskResponse
    {
        public int Id { get; set; }
        public string Note { get; set; }
        public DateTime? DueDate { get; set; }
        public bool Status { get; set; }
        public int OperationProcessId { get; set; }
    }
}
