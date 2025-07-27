using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorPharon.ViewModels
{
    public class BookingEditVM
    {
        public DateTime StartDate { get; set; }
        public int NumberOfPeople { get; set; }
    }
}
