namespace TrelloToMicrosoftPlannerMigrator.Models.TrelloBoardSubModels
{
    public class Label
    {
        public string id { get; set; }
        public string idBoard { get; set; }
        public string name { get; set; }
        public string color { get; set; }
        public PerBoard perBoard { get; set; }
    }


}
