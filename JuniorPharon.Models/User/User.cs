using Microsoft.AspNetCore.Identity;

namespace JuniorPharon.Models
{
    public class User : IdentityUser
    {
        public string? FirstName { get; set; }
        
        public string? LastName { get; set; }
        
        public string? NationalId { get; set; }
        
        public string? ProfileImg { get; set; }
        
        public DateTime? ModificationDate { get; set; }
        
        public DateTime? CreationDate { get; set; }
        
        public bool? IsDeleted { get; set; }
        
        public bool? IsActive { get; set; }
    }
}
