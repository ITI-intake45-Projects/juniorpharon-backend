﻿
namespace JuniorPharon.Models
{
    public class TripImages
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public int TripId { get; set; }
        public bool IsCover { get; set; }
        
        public virtual Trips Trip { get; set; }
    }
}
