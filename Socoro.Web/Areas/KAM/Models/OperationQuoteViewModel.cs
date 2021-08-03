using System.ComponentModel.DataAnnotations;

namespace Socoro.Web.Areas.KAM.Models
{
    public class OperationQuoteViewModel
    {
        public int Id { get; set; }
        [Required]
        public int Profit { get; set; }
        [Required]
        public int Documentation { get; set; }
        [Required]
        public int FF { get; set; }
        [Required, Display(Name ="Verified Gross Mass")]
        public int VGM { get; set; }
        [Required]
        public int Inland { get; set; }
        [Required]
        public int Others { get; set; }
        [Required]
        public string Explanation { get; set; }
    }
}
