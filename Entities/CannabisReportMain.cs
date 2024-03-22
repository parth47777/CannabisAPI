namespace CannabisAPI.Entities
{
    public class CannabisReportMain
    {
        public int CR_ID { get; set; }
        // Other properties need to match the columns in the table

        // Navigation properties
        public CannabisReport CannabisReport { get; set; }
    }
}
