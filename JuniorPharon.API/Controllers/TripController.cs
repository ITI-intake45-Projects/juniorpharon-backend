using JuniorPharon.Services;
using JuniorPharon.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JuniorPharon.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TripController : ControllerBase
    {

        private readonly TripService tripService;

        public TripController(TripService tripService)
        {
            this.tripService = tripService;
        }

        [HttpPost("CreateTrip")]
        public async Task<IActionResult> CreateTrip([FromForm] TripCreateVM vm)
        {
            var result = await tripService.CreateTrip(vm);
            if (result.IsSuccess)
            {
                return new JsonResult(result);
            }
            return new JsonResult(result);
        }

        [HttpGet("SearchTrip")]
        public async Task<IActionResult> SearchTrip([FromQuery] string? location = "",
           [FromQuery] string? city = "",
           [FromQuery] float? minPrice = null,
           [FromQuery] float? maxPrice = null,
           [FromQuery] int? durationInDays = null,
           [FromQuery] float? rating = null,
           [FromQuery] bool descending = false,
           [FromQuery] int pageSize = 10,
           [FromQuery] int pageIndex = 1)
        {
            var result = await tripService.SearchTrip(location, city, minPrice, maxPrice,
                durationInDays, rating, descending, pageSize, pageIndex);
            if (result.IsSuccess)
            {
                return new JsonResult(result);
            }
            return new JsonResult(result);
        }


        [HttpGet("AllTrips")]
        public async Task<IActionResult> GetAllTrips([FromQuery] int pageSize = 10, [FromQuery] int pageIndex = 2)
        {
            var result = await tripService.GetAllTrips(pageSize, pageIndex);
            if (result.IsSuccess)
            {
                return new JsonResult(result);
            }
            return new JsonResult(result);


        }

        [HttpGet("TripById")]
        public async Task<IActionResult> GetTripById([FromQuery] int Id )
        {
            var result = await tripService.GetTripById(Id);
            if (result.IsSuccess)
            {
                return new JsonResult(result);
            }
            return new JsonResult(result);


        }



    }
}
