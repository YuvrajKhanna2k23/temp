namespace ChatApp.Models.NotificationModel
{
    public class NotificationModel
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public int? GroupId { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ImageAddress { get; set; }
    }
}
