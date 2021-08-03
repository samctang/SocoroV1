using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Socoro.Web.Areas.KAM.Models
{
    public class OperationCargoViewModel
    {
        public int Id { get; set; }
        [Required, Display(Name = "Loading Address")]
        public string LoadingAddress { get; set; }
        [Required, Display(Name = "Contact Email")]
        public string ContactEmail { get; set; }
        [Required, Display(Name = "Contact Phone")]
        public string ContactPhone { get; set; }
        [Required, Display(Name = "Loading Date")]
        public DateTime LoadingDate { get; set; }
        [Required, Display(Name = "Loading Time")]
        public TimeSpan LoadingTime { get; set; }
        [Required, Display(Name = "Pick-Up Reference")]
        public string Reference { get; set; }
        [Required]
        public int EIN { get; set; }
        [Required]
        public bool Bonded { get; set; }
        [Required, Display(Name = "Self-Propelled")]
        public bool Propelled { get; set; }
        [Required, Display(Name = "Number of Containers")]
        public int NoContainers { get; set; }
        [Required]
        public List<ContainerViewModel> Containers { get; set; }
    }
}
