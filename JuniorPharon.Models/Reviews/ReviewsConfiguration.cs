using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JuniorPharon.Models;

public class ReviewsConfiguration : IEntityTypeConfiguration<Reviews>
{
    public void Configure(EntityTypeBuilder<Reviews> builder)
    {
        builder.HasKey(r => r.Id);
        builder.Property(r => r.Comment).IsRequired();
        builder.Property(r => r.Rating).IsRequired();
        builder.Property(r => r.CreationDate).HasDefaultValue(DateTime.Now);
        
    }
}