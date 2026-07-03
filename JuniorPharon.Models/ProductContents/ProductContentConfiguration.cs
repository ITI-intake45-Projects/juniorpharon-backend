using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JuniorPharon.Models
{
    public class ProductContentConfiguration : IEntityTypeConfiguration<ProductContent>
    {
        public void Configure(EntityTypeBuilder<ProductContent> builder)
        {
            builder.HasKey(pc => pc.Id);

            builder.Property(pc => pc.Name)
                   .IsRequired()
                   .HasMaxLength(200);

            builder.Property(pc => pc.Description)
                   .IsRequired();

            // منع تكرار اللغة لنفس المنتج (Unique Index)
            builder.HasIndex(pc => new { pc.ProductId, pc.LanguageCode })
                   .IsUnique();

            builder.HasOne(pc => pc.Product)
                   .WithMany(p => p.ProductContents)
                   .HasForeignKey(pc => pc.ProductId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}