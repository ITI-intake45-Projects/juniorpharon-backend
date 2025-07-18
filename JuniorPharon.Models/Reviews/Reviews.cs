using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorPharon.Models
{
    public class Reviews
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public float Rating { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual int TripId { get; set; }
        public virtual string ClientId { get; set; }
        
        public virtual Trips Trip { get; set; }
        public virtual User Client { get; set; }
    }
}
