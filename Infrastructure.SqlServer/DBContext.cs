using JuniorPharon.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.SqlServer;

public class DBContext : IdentityDbContext<User>
{
    public DBContext(DbContextOptions options) : base(options)
    {
        
    }
    public virtual DbSet<TripImage> TripImages { get; set; }
    public virtual DbSet<Review> Reviews { get; set; }
    public virtual DbSet<Booking> Bookings { get; set; }
    public virtual DbSet<Message> Messages { get; set; }
    public virtual DbSet<Notification> Notification { get; set; }
    public virtual DbSet<Chat> Chat { get; set; }
    public virtual DbSet<Trip> Trips { get; set; }
    public virtual DbSet<Payment> Payment { get; set; }
    public virtual DbSet<Admin> Admins { get; set; }
    public virtual DbSet<Client> Clients { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(typeof(BookingConfiguration).Assembly);
    }
    
}