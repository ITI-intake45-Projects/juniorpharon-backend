using JuniorPharon.Models.Enums;

namespace JuniorPharon.Models
{
    public class Bookings
    {
        public int Id { get; set; }
        public DateTime BookDate { get; set; }
        public BookingStatus Status { get; set; }
        public int NumberOfPeople { get; set; }
        public decimal TotalPrice { get; set; }

        public int TripId { get; set; } //fk
        public string ClientId { get; set; } //fk
        
        public virtual Trips Trip { get; set; }
        public virtual User Client { get; set; }

    }
}