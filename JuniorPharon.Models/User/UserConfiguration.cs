using JuniorPharon.Models.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace JuniorPharon.Models;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {

        builder.Property(b => b.Role).HasDefaultValue(Roles.Client);
        builder.Property(b => b.ModificationDate).HasDefaultValue(DateTime.Now);
        builder.Property(b => b.CreationDate).HasDefaultValue(DateTime.Now);
        

        
        
        
        
        builder.HasMany(b => b.Bookings)
            .WithOne(u => u.Client)
            .HasForeignKey(b => b.ClientId);
        
        
        builder.HasMany(b => b.Reviews)
            .WithOne(r => r.Client)
            .HasForeignKey(r => r.ClientId);
        
        
        builder.HasMany(b => b.SentMessages)
            .WithOne(m => m.Sender)
            .HasForeignKey(m => m.SenderId);
        
        builder.HasMany(b => b.ReceivedMessages)
            .WithOne(m => m.Receiver)
            .HasForeignKey(m => m.ReceiverId);
        
        builder.HasMany(b => b.Notifications)
            .WithOne(n => n.User)
            .HasForeignKey(n => n.UserId);
        
        builder.HasMany(b => b.Trips)
            .WithOne(t => t.CreatedByUser)
            .HasForeignKey(t => t.CreatedBy);
            
        
    }
}