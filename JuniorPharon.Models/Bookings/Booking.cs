using System.ComponentModel.DataAnnotations.Schema;
using JuniorPharon.Models.Enums;

namespace JuniorPharon.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public DateTime BookDate { get; set; } = DateTime.Now;
        public BookingStatus Status { get; set; }
        public int NumberOfPeople { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate  {get;set;}
        public int DurationInDays => Trip.DurationInDays;

        // [NotMapped]
        public int TripId { get; set; } //fk
        public string ClientId { get; set; } //fk
        public virtual Trip Trip { get; set; }
        public virtual User Client { get; set; }
        public virtual Payment Payment { get; set; }
    }
}