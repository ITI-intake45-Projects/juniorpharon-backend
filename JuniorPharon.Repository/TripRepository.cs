using Infrastructure.SqlServer;
using JuniorPharon.Models;
using JuniorPharon.ViewModels;
using LinqKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorPharon.Repository
{
    public class TripRepository : BaseRepository<Trip>
    {
        public TripRepository(DBContext context) : base(context)
        {
        }

        public async Task<PaginationVM<TripDetailsVM>> SearchTripDetails(
           string? location = "",
           string? city = "",
           float? minPrice = null,
           float? maxPrice = null,
           int? durationInDays = null,
           float? rating = null,
           bool descending = false,
           int pageSize = 10,
           int pageIndex = 1)
        {
            try
            {

                var predicate = PredicateBuilder.New<Trip>(true);

                if (!string.IsNullOrEmpty(location))
                    predicate = predicate.And(m => m.Location == location);

                if (!string.IsNullOrEmpty(city))
                    predicate = predicate.And(m => m.City == city);

                if (minPrice.HasValue)
                    predicate = predicate.And(t => t.Price >= minPrice.Value);

                if (maxPrice.HasValue)
                    predicate = predicate.And(t => t.Price <= maxPrice.Value);

                if (durationInDays.HasValue)
                    predicate = predicate.And(t => t.DurationInDays == durationInDays.Value);

                if (rating.HasValue)
                    predicate = predicate.And(t => t.Reviews.Average(r=> r.Rating) >= rating.Value);





                return await SearchAsync(predicate, m => m.DurationInDays, m => m.ToDetails(), false, pageSize, pageIndex);
            }
            catch
            {
                throw;
            }
        }

        public async Task<PaginationVM<TripDetailsVM>> GetAllTripsAsync(
       int pageSize = 10,
       int pageIndex = 1)
        {
            try
            {
                return await SearchAsync(
                    null,                          // no filter (يعني هات الكل)
                    m => m.CreatedAt,              // order by StartDate
                    m => m.ToDetails(),            // projection
                    false,                         // ascending
                    pageSize,
                    pageIndex
                );
            }
            catch
            {
                throw;
            }
        }
    }
}
