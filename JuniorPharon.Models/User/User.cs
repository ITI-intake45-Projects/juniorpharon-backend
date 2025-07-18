using JuniorPharon.Models.Enums;
using Microsoft.AspNetCore.Identity;

namespace JuniorPharon.Models
{
    public class User : IdentityUser
    {
        public string? FirstName { get; set; }
        
        public string? LastName { get; set; }
        
        public string? NationalId { get; set; }
        
        public string? ProfileImg { get; set; }
        
        public Roles  Role { get; set; }
        
        public DateTime? ModificationDate { get; set; }
        
        public DateTime? CreationDate { get; set; }
        
        public bool? IsDeleted { get; set; }
        
        public bool? IsActive { get; set; }
        
        public string? ProfileImgUrl { get; set; }
        
        
        public ICollection<Bookings> Bookings { get; set; }
        public ICollection<Reviews> Reviews { get; set; }
        public ICollection<Messages> SentMessages { get; set; }
        public ICollection<Messages> ReceivedMessages { get; set; }
    }
}
