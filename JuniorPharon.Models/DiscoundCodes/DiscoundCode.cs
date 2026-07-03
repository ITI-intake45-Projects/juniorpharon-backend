using JuniorPharon.Models.Enums;

namespace JuniorPharon.Models
{
    public class DiscountCode
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int? MaxUsage { get; set; }
        public int UsedCount { get; set; } = 0;

        public int? MinPeople { get; set; }
        public decimal? MinAmount { get; set; }

        public DiscountType Type { get; set; } // Percentage or Fixed
        public decimal Value { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // العلاقات - الخصم ممكن يكون لشيء محدد أو عام
        public int? TripId { get; set; }
        public int? PackageId { get; set; }
        public int? ProductId { get; set; } // 🆕 إضافة المنتج

        public bool IsActive { get; set; } = true;

        // Navigation Properties
        public virtual Trip? Trip { get; set; }
        public virtual Package? Package { get; set; }
        public virtual Product? Product { get; set; }
    }
}