namespace CannabisAPI.Models
{
    public class AgencyData
    {
        public string AgencyName { get; set; }
        public Dictionary<string, CategoryData> Categories { get; set; }

        public AgencyData(Dictionary<string, CategoryData> categories) => Categories = categories;
    }
    public class CategoryData
    {
        public int Arrests { get; set; }
        public int Citations { get; set; }
        public int PenaltyAssesments { get; set; }
        public GenderData Gender { get; set; }
        public Dictionary<string, int> Age { get; set; }
        public RaceData Race { get; set; }
        public EthnicityData Ethnicity { get; set; }
        public Dictionary<string, int> PenaltyLevel { get; set; }

        public CategoryData(Dictionary<string, int> penaltyLevel)
        {
            PenaltyLevel = penaltyLevel;
        }
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
        public int Unknown { get; set; }
    }

    public class EthnicityData
    {
        public int HispanicLatino { get; set; }
        public int NotHispanicLatino { get; set; }
        public int Unknown { get; set; }
    }

}
