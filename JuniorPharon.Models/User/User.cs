using JuniorPharon.Models.Enums;
using Microsoft.AspNetCore.Identity;

namespace JuniorPharon.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        
        public string? LastName { get; set; }
        
        public string? NationalId { get; set; }
        
        public string Nationality { get; set; }
        
        public int? Age { get; set; }
        
        public string? ProfileImg { get; set; }
        
        public Gender Gender { get; set; }
        public Roles  Role { get; set; }
        public DateTime? ModificationDate { get; set; }
        public DateTime? CreationDate { get; set; }
        
        public bool? IsDeleted { get; set; }
        
        public bool? IsActive { get; set; }
        
        public string? ProfileImgUrl { get; set; }
        
        // Relations
        public virtual ICollection<Trips> Trips { get; set; }
        public virtual ICollection<Bookings> Bookings { get; set; }
        public virtual ICollection<Reviews> Reviews { get; set; }
        public virtual ICollection<Messages> SentMessages { get; set; }
        public virtual ICollection<Messages> ReceivedMessages { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
