using JuniorPharon.Models.Enums;

namespace JuniorPharon.Models
{
    public class ProductContent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public LanguageCode LanguageCode { get; set; } // Enum: 0 = AR, 1 = EN

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}