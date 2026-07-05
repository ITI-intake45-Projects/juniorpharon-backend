using JuniorPharon.Models.Enums;

namespace JuniorPharon.ViewModels
{
    public class GiftDetailsVM
    {
        public int Id { get; set; }

        public ProductDetailsVM Product { get; set; }

        public int? TripId { get; set; }

        public int? PackageId { get; set; }

        public int Quantity { get; set; }

        public bool IsActive { get; set; }

        public string? TripName { get; set; }

        public string? PackageName { get; set; }

    }
}