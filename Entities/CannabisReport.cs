namespace CannabisAPI.Entities
{
    public class CannabisReport
    {
        public int CR_ID { get; set; }
        public int CRI_ID { get; set; }
        public int Agency_ID { get; set; }
        public string JS_FILE { get; set; }
        public string Report_Complete { get; set; }

        // Navigation properties
        public CannabisReportMain CannabisReportMain { get; set; }
        public ICollection<AuditCannabisReport> AuditCannabisReports { get; set; }
    }
}

