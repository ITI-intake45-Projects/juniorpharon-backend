using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JuniorPharon.Models;

public class MessagesConfiguration : IEntityTypeConfiguration<Messages>
{
    public void Configure(EntityTypeBuilder<Messages> builder)
    {
        builder.HasKey(m => m.Id);
        builder.Property(m => m.Message ).HasColumnType("nvarchar(MAX)");
        builder.Property(m => m.SentAt).HasDefaultValue(DateTime.Now);
        
        builder.HasOne(m => m.Chat)
            .WithMany(c => c.Messages)
            .HasForeignKey(m => m.ChatId);
    }
}