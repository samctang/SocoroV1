using Socoro.Domain.Entities;
using System;

namespace Socoro.Application.DTOs.Operation
{
    public class OperationProcessResponse
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public string Status { get; set; }
        public int OperationId { get; set; }
    }
}
