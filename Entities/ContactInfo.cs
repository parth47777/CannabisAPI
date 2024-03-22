namespace CannabisAPI.Entities
{
    public class ContactInfo
    {
        public int CI_ID { get; set; }
        public int Agency_ID { get; set; }
        public string Contact_Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Created_By { get; set; }
        public DateTime Created_Date { get; set; }

        // Navigation properties
        public Agency Agency { get; set; }
    }
}
