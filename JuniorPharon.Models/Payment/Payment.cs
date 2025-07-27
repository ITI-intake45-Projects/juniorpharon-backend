using JuniorPharon.Models.Enums;

namespace JuniorPharon.Models;

public class Payment
{
    public int Id { get; set; }
    public PaymentMethod Method { get; set; }  // Enum: Cash, Visa, etc.
    public bool IsDone { get; set; } = false;

    public int BookingId { get; set; } // FK to Booking
    public virtual Booking Booking { get; set; }

    public string ClientId { get; set; }  // Optional if you want to track who paid
    public virtual User Client { get; set; }
}