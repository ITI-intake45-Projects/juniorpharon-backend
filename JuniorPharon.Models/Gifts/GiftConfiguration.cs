using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JuniorPharon.Models.Gifts
{
    public class GiftConfiguration : IEntityTypeConfiguration<Gift>
    {
        public void Configure(EntityTypeBuilder<Gift> builder)
        {
            builder.ToTable("Gifts");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Quantity)
                   .HasDefaultValue(1);

            builder.Property(x => x.IsActive)
                   .HasDefaultValue(true);

            // Product (Required)
            builder.HasOne(x => x.Product)
                   .WithMany(x => x.Gifts)
                   .HasForeignKey(x => x.ProductId)
                   .OnDelete(DeleteBehavior.Restrict);

            // Trip (Optional)
            builder.HasOne(x => x.Trip)
                   .WithMany(x => x.Gifts)
                   .HasForeignKey(x => x.TripId)
                   .OnDelete(DeleteBehavior.Cascade);

            // Package (Optional)
            builder.HasOne(x => x.Package)
                   .WithMany(x => x.Gifts)
                   .HasForeignKey(x => x.PackageId)
                   .OnDelete(DeleteBehavior.Cascade);

            // لازم تكون الهدية مرتبطة إما بـ Trip أو Package
            builder.ToTable(t =>
                t.HasCheckConstraint(
                    "CK_Gift_TripOrPackage",
                    "([TripId] IS NOT NULL OR [PackageId] IS NOT NULL)"
                ));
        }
    }
}