namespace CannabisAPI.Models
{
    public class AgencyData
    {
        public bool Completed { get; set; }
        public string AgencyId { get; set; } // Updated from new Body Post from AgencyName to match the POST body

        // Explicitly defined categories
        public CategoryData PersonalProduction { get; set; }
        public CategoryData UnlicensedSale { get; set; }
        public CategoryData RestrictedArea { get; set; }
        public CategoryData UnlawfulPossession { get; set; }
        public CategoryData UnlicensedManufacturing { get; set; }
        public CategoryData DUI { get; set; }
        public CategoryData ADUI { get; set; }
        public CategoryData OperatingMotorboat { get; set; }
        public CategoryData AggravatedOperatingMotorboat { get; set; }
    }

    public class CategoryData
    {
        public int Arrests { get; set; }
        public int Citations { get; set; }
        public int PenaltyAssessments { get; set; }
        public GenderData Gender { get; set; }
        public Dictionary<string, int> Age { get; set; }
        public RaceData Race { get; set; }
        public EthnicityData Ethnicity { get; set; }
        public Dictionary<string, int> PenaltyLevel { get; set; }
    }

    public class GenderData
    {
        public int Male { get; set; }
        public int Female { get; set; }
    }

    public class RaceData
    {
        public int White { get; set; }
        public int Black { get; set; }
        public int AmericanIndianAlaskanNative { get; set; }
        public int AsianPacificIslander { get; set; }
        public int Unknown { get; set; }
    }

    public class EthnicityData
    {
        public int HispanicLatino { get; set; }
        public int NotHispanicLatino { get; set; }
        public int Unknown { get; set; }
    }
}
