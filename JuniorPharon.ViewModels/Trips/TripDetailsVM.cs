
namespace JuniorPharon.ViewModels
{
    public class TripDetailsVM
    {
        public int Id { get; set; }

        public string Location { get; set; }

        public string City { get; set; }
        public float Price { get; set; }

        public int DurationInDays { get; set; }
        public string CreatedByUserId { get; set; }

        public DateTime CreatedAt { get; set; }

        public float Rating { get; set; }

        public List<TripContentDetailsVM> TripContents { get; set; } 
        //public List<string> TripImages { get; set; } 
        public List<TripImageDetailsVM> TripImages { get; set; }

    }
}
