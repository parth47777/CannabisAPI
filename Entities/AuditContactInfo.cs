namespace CannabisAPI.Entities
{
    public class AuditContactInfo
    {
        public int ACI_ID { get; set; }
        public int CI_ID { get; set; }
        public string AGENCY_ID { get; set; }
        public string CONTACT_NAME { get; set; }
        public string EMAIL { get; set; }
        public string PHONE { get; set; }
        public string CREATED_BY { get; set; }
        public DateTime CREATED_DATE { get; set; }
        public DateTime AUDIT_DATE { get; set; }
        public string AUDIT_ACTION { get; set; }  

    }
}
