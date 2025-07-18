using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JuniorPharon.Models;

public class TripImagesConfiguration : IEntityTypeConfiguration<TripImages>
{
    public void Configure(EntityTypeBuilder<TripImages> builder)
    {
        builder.HasKey(img => img.Id);
        builder.Property(img => img.ImageUrl).IsRequired();
        builder.Property(img => img.IsCover).HasDefaultValue(false);
        
    }
}