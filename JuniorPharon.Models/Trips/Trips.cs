﻿

namespace JuniorPharon.Models
{
    public class Trips
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public float Price { get; set; }
        
        // public DateTime StartDate { get; set; }
        // public DateTime EndDate { get; set; }
        
        public int DurationInDays { get; set; } // trip duration
        public string CreatedBy { get; set; }//fk owner
        public DateTime CreatedAt { get; set; }
        
        //Relation
        
        public virtual User CreatedByUser { get; set; }
        public virtual ICollection<Bookings> Bookings { get; set; }
        public virtual ICollection<TripImages> TripImages { get; set; }
        public virtual ICollection<Reviews> Reviews { get; set; }
        
    }
}
