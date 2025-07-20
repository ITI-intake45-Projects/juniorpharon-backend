

namespace JuniorPharon.Models
{
    public class Messages
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime SentAt { get; set; } = DateTime.Now;
        
        //Relations
        public string SenderId { get; set; }
        public string ReceiverId { get; set; }
        
        public int ChatId { get; set; }
        public virtual User Receiver { get; set; }
        public virtual User Sender { get; set; }
        
        public virtual Chat Chat { get; set; }
        
    }
}
