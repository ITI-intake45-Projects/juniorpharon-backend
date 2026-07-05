using System.ComponentModel.DataAnnotations;

namespace JuniorPharon.ViewModels
{
    public class GiftCreateVM
    {
        [Required]
        public int ProductId { get; set; }

        public int? TripId { get; set; }

        public int? PackageId { get; set; }

        [Range(1, int.MaxValue)]
        public int Quantity { get; set; } = 1;

        public bool IsActive { get; set; } = true;
    }
}