namespace TrelloToMicrosoftPlannerMigrator.Models
{
    public class MigrationConfiguration
    {
        public bool IncludeLists { get; set; }
        public bool IncludeCards { get; set; }
        public bool IncludeActions { get; set; }
        public bool IncludeChecklists { get; set; }
        public bool IncludeLabels { get; set; }
        public bool IncludePlaceholder { get; set; }
    }


}
