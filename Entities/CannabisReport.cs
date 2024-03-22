namespace CannabisAPI.Entities
{
    public class CannabisReport
    {
        public int CR_ID { get; set; }
        // Other properties need to match the columns in the table

        // Navigation properties
        // Assuming CannabisReportMain relationship
        public CannabisReportMain CannabisReportMain { get; set; }
        public ICollection<AuditCannabisReport> AuditCannabisReports { get; set; }
    }
}

