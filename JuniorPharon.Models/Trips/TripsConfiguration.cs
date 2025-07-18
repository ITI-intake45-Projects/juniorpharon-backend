using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JuniorPharon.Models;

public class TripsConfiguration : IEntityTypeConfiguration<Trips>
{
    public void Configure(EntityTypeBuilder<Trips> builder)
    {
        builder.HasKey(t => t.Id);
        builder.Property(t => t.Title).IsRequired();
        builder.Property(t => t.Description).IsRequired();
        builder.Property(t => t.DurationInDays).IsRequired();   
        
        builder.Property(t => t.Location).IsRequired();
        builder.Property(t => t.Price).IsRequired();
        
        
        
        
    }
}