using JuniorPharon.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.SqlServer;

public class DBContext : IdentityDbContext<User>
{
    public DBContext(DbContextOptions options) : base(options)
    {
        
    }
    public virtual DbSet<TripImages> TripImages { get; set; }
    public virtual DbSet<Reviews> Reviews { get; set; }
    public virtual DbSet<Bookings> Bookings { get; set; }
    public virtual DbSet<Messages> Messages { get; set; }
    public virtual DbSet<Notification> Notification { get; set; }
    public virtual DbSet<Chat> Chat { get; set; }
    public virtual DbSet<Trips> Trips { get; set; }
    public virtual DbSet<Payment> Payment { get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(typeof(BookingsConfiguration).Assembly);
    }
    
}