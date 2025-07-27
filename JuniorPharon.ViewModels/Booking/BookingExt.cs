

using JuniorPharon.Models;

namespace JuniorPharon.ViewModels
{
    public static class BookingExt
    {
        public static Booking ToCreate(this BookingCreateVM vm)
        {
            return new Booking
            {
                TripId = vm.TripId,
                ClientId = vm.ClientId,
                StartDate = vm.StartDate,
                NumberOfPeople = vm.NumberOfPeople
            };
        }
        public static BookingDetailsVM ToDetails(this Booking booking)
        {
            return new BookingDetailsVM
            {
                Id = booking.Id,
                BookDate = booking.BookDate,
                Status = booking.Status,
                NumberOfPeople = booking.NumberOfPeople,
                TotalPrice = booking.TotalPrice,
                StartDate = booking.StartDate,
                EndDate = booking.EndDate,
                DurationInDays = booking.DurationInDays,
                TripId = booking.TripId,
                ClientId = booking.ClientId,
                //TripTitle = booking.Trip?.TripContents.FirstOrDefault() ?? string.Empty,
                ClientName = booking.Client?.FirstName +" "+ booking.Client?.LastName ?? string.Empty
            };
        }
        public static Booking ToEdit(this BookingEditVM newModel, Booking oldModel)
        {
            oldModel.StartDate = newModel.StartDate == default ? oldModel.StartDate : newModel.StartDate;
            oldModel.NumberOfPeople = newModel.NumberOfPeople == 0 ? oldModel.NumberOfPeople : newModel.NumberOfPeople;


            return oldModel;
        }
    }
}
