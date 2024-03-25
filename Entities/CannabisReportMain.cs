namespace CannabisAPI.Entities
{
    public class CannabisReportMain
    {
        public int CR_ID { get; set; }

        // Navigation properties
        public CannabisReport CannabisReport { get; set; }
    }
}

