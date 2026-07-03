namespace JuniorPharon.Models
{
    public class ProductImage
    {
        public int Id { get; set; }

        public string ImageUrl { get; set; } // مسار الصورة أو الـ URL

        public bool IsCover { get; set; } // هل هي الصورة الرئيسية للمنتج؟

        // Foreign Key
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}