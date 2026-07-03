using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JuniorPharon.Models
{
    public class ReceiptConfiguration : IEntityTypeConfiguration<Receipt>
    {
        public void Configure(EntityTypeBuilder<Receipt> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.QuotedPrice)
                   .HasColumnType("decimal(18,2)");

            builder.Property(i => i.ReceiptDate)
                   .HasDefaultValueSql("GETDATE()");

            // علاقة One-to-One مع الـ Booking
            // كل حجز له استعلام واحد (إيصال واحد)
            builder.HasOne(i => i.Booking)
                   .WithOne(b => b.Receipt) // تأكد من تغيير المسمى في كلاس Booking أيضاً
                   .HasForeignKey<Receipt>(i => i.BookingId);

            builder.HasOne(i => i.Client)
                   .WithMany() // أو WithMany(u => u.Inquiries)
                   .HasForeignKey(i => i.ClientId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}