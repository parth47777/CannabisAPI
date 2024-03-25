namespace CannabisAPI.Entities
{
    public class AuditCannabisReport
    {
        public int ACR_ID { get; set; }
        public int CR_ID { get; set; }
        public int CRI_ID { get; set; }
        public int Agency_ID { get; set; }
        public string JS_File { get; set; }
        public DateTime Audit_Date { get; set; }
        public string Audit_Action { get; set; }

        // Navigation properties
        public CannabisReport CannabisReport { get; set; }
        public Agency Agency
        {
            get; set;
        }
    }
}