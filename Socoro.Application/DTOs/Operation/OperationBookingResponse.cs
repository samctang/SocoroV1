using System;

namespace Socoro.Application.DTOs.Operation
{
    public class OperationBookingResponse
    {
        public int Id { get; set; }
        public string BookingNumber { get; set; }
        public string Vessel { get; set; }
        public int Voyage { get; set; }
        public DateTime DocumentDate { get; set; }
        public TimeSpan DocumentTime { get; set; }
        public DateTime CargoDate { get; set; }
        public TimeSpan CargoTime { get; set; }
        public DateTime VGMDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public bool Ramp { get; set; }
        public DateTime RampDate { get; set; }
        public int OperationCargoId { get; set; }
    }
}
