using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JuniorPharon.Models;

public class NotificationConfiguration : IEntityTypeConfiguration<Notification>
{
    public void Configure(EntityTypeBuilder<Notification> builder)
    {
        builder.HasKey(n => n.Id);
        builder.Property(n => n.CreatedAt).HasDefaultValue(DateTime.Now);
        builder.Property(n => n.IsRead).HasDefaultValue(false);
        builder.Property(n => n.Description).IsRequired();
        builder.Property(n => n.ReceiverId).IsRequired();
        builder.Property(n => n.Type).IsRequired();
        
        
        
        
        
    }
}