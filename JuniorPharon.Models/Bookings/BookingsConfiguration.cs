using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JuniorPharon.Models;


public class BookingsConfiguration : IEntityTypeConfiguration<Bookings>
{
    public void Configure(EntityTypeBuilder<Bookings> builder)
    {
        builder.HasKey(bookings => bookings.Id);
        builder.Property(bookings => bookings.BookDate).HasColumnType("date").HasDefaultValue(DateTime.Now);
        builder.Property(bookings => bookings.Status ).HasColumnType("tinyint").HasDefaultValue(0);
        builder.Property(t => t.EndDate)
            .HasComputedColumnSql("[StartDate] + [DurationInDays]", stored: false);
        
        
        
    }
}