namespace TrelloToMicrosoftPlannerMigrator.Models
{
    public class MigrationConfiguration
    {
        public bool IncludeArchivedLists { get; set; }
        public bool IncludeArchivedCards { get; set; }
        public bool IncludeActions { get; set; }
        public bool IncludeChecklists { get; set; }
        public bool IncludeLabels { get; set; }
        public bool IncludePlaceholder { get; set; }
    }


}
