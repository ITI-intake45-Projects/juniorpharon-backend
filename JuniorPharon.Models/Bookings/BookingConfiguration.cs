using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JuniorPharon.Models;


public class BookingConfiguration : IEntityTypeConfiguration<Booking>
{
    public void Configure(EntityTypeBuilder<Booking> builder)
    {
        builder.HasKey(bookings => bookings.Id);
        builder.Property(bookings => bookings.BookDate).HasColumnType("date").HasDefaultValue(DateTime.Now);
        builder.Property(bookings => bookings.Status ).HasColumnType("tinyint").HasDefaultValue(0);
        builder.Property(t => t.EndDate)
            .HasComputedColumnSql("[StartDate] + [DurationInDays]", stored: false);
        
        
        
    }
}