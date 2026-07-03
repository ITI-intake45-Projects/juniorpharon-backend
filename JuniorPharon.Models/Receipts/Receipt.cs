namespace JuniorPharon.Models
{
    public class Receipt
    {
        public int Id { get; set; }

        // وقت التواصل
        public DateTime ReceiptDate { get; set; } = DateTime.Now;

        // رسالة إضافية لو العميل كتب حاجة قبل ما يروح للواتساب
        public string? CustomerNote { get; set; }

        // السعر التقريبي اللي العميل شافه وقت الطلب
        public decimal QuotedPrice { get; set; }

        // الربط مع الحجز
        public int BookingId { get; set; }
        public virtual Booking Booking { get; set; }

        // العميل
        public string ClientId { get; set; }
        public virtual User Client { get; set; }
    }
}