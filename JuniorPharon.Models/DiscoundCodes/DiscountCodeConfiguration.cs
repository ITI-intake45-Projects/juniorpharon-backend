using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JuniorPharon.Models
{
    public class DiscountCodeConfiguration : IEntityTypeConfiguration<DiscountCode>
    {
        public void Configure(EntityTypeBuilder<DiscountCode> builder)
        {
            builder.HasKey(d => d.Id);

            // الكود لازم يكون فريد (Unique) عشان ميتكررش
            builder.HasIndex(d => d.Code).IsUnique();

            builder.Property(d => d.Code)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(d => d.Value)
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();

            builder.Property(d => d.MinAmount)
                   .HasColumnType("decimal(18,2)");

            // تحويل الـ Enum لنصوص في الداتا بيز لسهولة القراءة
            builder.Property(d => d.Type)
                   .HasConversion<string>();

            // العلاقات
            builder.HasOne(d => d.Trip)
                   .WithMany()
                   .HasForeignKey(d => d.TripId)
                   .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(d => d.Package)
                   .WithMany()
                   .HasForeignKey(d => d.PackageId)
                   .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(d => d.Product)
                   .WithMany()
                   .HasForeignKey(d => d.ProductId)
                   .OnDelete(DeleteBehavior.SetNull);

            // 🔥 تريك احترافية: Check Constraint لضمان إن الخصم منطقي
            builder.ToTable(t =>
            {
                t.HasCheckConstraint("CK_Discount_Date", "EndDate > StartDate");
                t.HasCheckConstraint("CK_Discount_Value", "Value > 0");
            });
        }
    }
}