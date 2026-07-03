using System.ComponentModel.DataAnnotations;

namespace JuniorPharon.ViewModels
{
    public class ProductEditVM
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than zero.")]
        public decimal Price { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Stock Quantity cannot be negative.")]
        public int StockQuantity { get; set; }

        public bool IsActive { get; set; }
    }
}