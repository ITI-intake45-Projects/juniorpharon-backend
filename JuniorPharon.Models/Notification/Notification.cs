using JuniorPharon.Models.Enums;

namespace JuniorPharon.Models;

public class Notification
{
    public int Id { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsRead { get; set; }
    public string Title { get; set; }
    public NotificationType  Type { get; set; }
    
    //Relations
    public string UserId  { get; set; }
    public virtual User User { get; set; }
    
}