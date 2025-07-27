
using JuniorPharon.Models;
using JuniorPharon.Models.Enums;

namespace JuniorPharon.ViewModels
{
    public class BookingDetailsVM
    {
        public int Id { get; set; }
        public DateTime BookDate { get; set; }
        public BookingStatus Status { get; set; }
        public int NumberOfPeople { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int DurationInDays { get; set; }
        public int TripId { get; set; } 
        public string ClientId { get; set; } 
        public string TripTitle { get; set; }
        public string ClientName { get; set; }

    }
}
