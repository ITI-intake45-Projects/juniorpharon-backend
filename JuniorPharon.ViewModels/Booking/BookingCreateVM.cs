using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorPharon.ViewModels
{
    public class BookingCreateVM
    {
        public int TripId { get; set; }
        public string ClientId { get; set; }
        [Required(ErrorMessage = "start date is required.")]

        public DateTime StartDate { get; set; }
        [Required(ErrorMessage = "number of people is required.")]
        public int NumberOfPeople { get; set; }
    }
}
