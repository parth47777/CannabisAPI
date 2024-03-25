using System.ComponentModel.DataAnnotations;

namespace CannabisAPI.Models
{
    public class Agency
    {
        [Key]
        public string AgencyId { get; set; }
        public string AgencyName { get; set; }
        public string ActiveFlag { get; set; }
        // Navigation properties for related tables can be added here
    }
}

