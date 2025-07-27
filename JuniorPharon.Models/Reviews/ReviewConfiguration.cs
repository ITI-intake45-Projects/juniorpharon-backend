using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JuniorPharon.Models;

public class ReviewConfiguration : IEntityTypeConfiguration<Review>
{
    public void Configure(EntityTypeBuilder<Review> builder)
    {
        builder.HasKey(r => r.Id);
        builder.Property(r => r.Comment).IsRequired();
        builder.Property(r => r.Rating).IsRequired();
        builder.Property(r => r.CreationDate).HasDefaultValue(DateTime.Now);
        
    }
}