namespace EmailChatProject.Entities
{
    public class Message
    {
        public int MessageID { get; set; }
        public string SenderEmail { get; set; }
        public string SenderName { get; set; } 
        public string ReceiverEmail { get; set; }
        public string ReceiverName { get; set; }
        public string Subject { get; set; }
        public string MessageDetail { get; set; }
        public bool IsRead { get; set; }
        public DateTime SendDate { get; set; }
    }
}
