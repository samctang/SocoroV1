using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Socoro.Web.Areas.KAM.Models
{
    public class OperationBookingViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Booking Number")]
        public string BookingNumber { get; set; }
        public string Vessel { get; set; }
        public int Voyage { get; set; }
        [Display(Name = "Document Date")]
        public DateTime DocumentDate { get; set; }
        [Display(Name = "Document Time")]
        public TimeSpan DocumentTime { get; set; }
        [Display(Name = "Cargo Date")]
        public DateTime CargoDate { get; set; }
        [Display(Name = "Cargo Time")]
        public TimeSpan CargoTime { get; set; }
        [Display(Name = "VGM Date")]
        public DateTime VGMDate { get; set; }
        [Display(Name = "Departure Date")]
        public DateTime DepartureDate { get; set; }
        [Display(Name = "Arrival Date")]
        public DateTime ArrivalDate { get; set; }
        public bool Ramp { get; set; }
        [Display(Name = "Ramp Date")]
        public DateTime RampDate { get; set; }
        [Required, Display(Name = "Number of Containers")]
        public int NoContainers { get; set; }
        [Display(Name = "No. of Containers")]
        public int OperationCargoId { get; set; }
    }
}
