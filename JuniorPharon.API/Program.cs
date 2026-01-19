using Infrastructure.SqlServer;
using JuniorPharon.Models;
using JuniorPharon.Repository;
using JuniorPharon.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<UserRepository>();
builder.Services.AddScoped<AdminRepository>();
builder.Services.AddScoped<BookingRepository>();
builder.Services.AddScoped<NotificationRepository>();
builder.Services.AddScoped<PaymentRepository>();
builder.Services.AddScoped<ReviewRepository>();
builder.Services.AddScoped<TripRepository>();
builder.Services.AddScoped<UserRepository>();
builder.Services.AddScoped<UnitOfWork>();
//builder.Services.AddScoped<AccountService>();
builder.Services.AddScoped<TripService>();
builder.Services.AddScoped<DashboardService>();



builder.Services.AddDbContext<DBContext>
    (i => i.UseLazyLoadingProxies().UseSqlServer(builder.Configuration.GetConnectionString("JuniorPharonDB")));
builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<DBContext>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();