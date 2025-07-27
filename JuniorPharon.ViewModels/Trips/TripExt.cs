
using JuniorPharon.Models;

namespace JuniorPharon.ViewModels
{
    public static class TripExt
    {
        
        public static Trip ToCreate(this TripCreateVM TripVm , List<string> imgUrls)
        {
            return new Trip
            { 
                Price = TripVm.Price,
                DurationInDays = TripVm.DurationInDays,
                Location = TripVm.Location,
                City = TripVm.City,
                CreatedAt = DateTime.Now,
                CreatedBy = TripVm.CreatedByUserId,
                TripContents = TripVm.TripContents.Select(c => c.ToCreate()).ToList(),
                //TripImages = TripVm.TripPath.Select(p => new TripImage { ImageUrl = p }).ToList(),
                TripImages = TripVm.TripImages.Select((imgVm , index)
                => imgVm.ToCreate(imgUrls[index])).ToList() 
              
            };
        }
        public static TripDetailsVM ToDetails(this Trip trip)
        {
            return new TripDetailsVM
            {
                Id = trip.Id,
                Location = trip.Location,
                City = trip.City,
                Price = trip.Price,
                DurationInDays = trip.DurationInDays,
                CreatedByUserId = trip.CreatedBy,
                CreatedAt = trip.CreatedAt,
                Rating = trip.Reviews
            };
        }
    }
}
