namespace CannabisAPI.Entities
{
    public class NotificationTracking
    {
        public int NT_ID { get; set; }
        public int Agency_ID { get; set; }
        public DateTime Email_Notification_Date { get; set; }
        public string Email_To { get; set; }
        public string Email_CC { get; set; }
        public string Email_Subject { get; set; }
        public string Email_Body { get; set; }

        // Navigation properties
        public Agency Agency { get; set; }
    }
}
