namespace CannabisAPI.Entities
{
    public class Agency
    {
        public int Agency_ID { get; set; }
        public string Agency_Name { get; set; }
        public bool Active_Flag { get; set; }

        // Navigation properties
        public ICollection<AccessCode> AccessCodes { get; set; }
       
    }
}