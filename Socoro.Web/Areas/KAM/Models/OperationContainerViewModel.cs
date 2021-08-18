using System.ComponentModel.DataAnnotations;

namespace Socoro.Web.Areas.KAM.Models
{
    public class OperationContainerViewModel
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        [Display(Name="Gross Weight")]
        public int GrossWeight { get; set; }
        [Display(Name = "Commercial Description")]
        public string CommercialDescription { get; set; }
        public bool Hazardous { get; set; }
        public string HazardClass { get; set; }
        public int UNCode { get; set; }
        public string ContainerNo { get; set; }
        public string SealNo { get; set; }
        public int TareWeight { get; set; }
        public string Commodities { get; set; }
        public string Marks { get; set; }
    }
}
