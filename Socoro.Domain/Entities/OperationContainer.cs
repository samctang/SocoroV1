
namespace Socoro.Domain.Entities
{
    public class OperationContainer : AuditableEntity
    {
        public int TypeId { get; set; }
        public int GrossWeight { get; set; }
        public string CommercialDescription { get; set; }
        public bool Hazardous { get; set; }
        public string HazardClass { get; set; }
        public int UNCode { get; set; }
        public string ContainerNo { get; set; }
        public string SealNo { get; set; }
        public int TareWeight { get; set; }
    }
}
