namespace CannabisAPI.Entities
{
    public class AccessCode
    {
        public int AC_ID { get; set; }
        public int Agency_ID { get; set; }
        public int Fiscal_Year { get; set; }
        public DateTime Effective_Date { get; set; }
        public DateTime Expiration_Date { get; set; }
        public string Access_Key { get; set; }

        // Navigation properties
        public Agency Agency { get; set; }
        // Other related entities
    }
}
