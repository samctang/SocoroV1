using System;

namespace Socoro.Application.DTOs.Operation
{
    public class OperationCargoResponse
    {
        public int Id { get; set; }
        public string LoadingAddress { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public DateTime LoadingDate { get; set; }
        public TimeSpan LoadingTime { get; set; }
        public string Reference { get; set; }
        public int EIN { get; set; }
        public bool Bonded { get; set; }
        public bool Propelled { get; set; }
        public int NoContainers { get; set; }
        public int OperationId { get; set; }
    }
}
