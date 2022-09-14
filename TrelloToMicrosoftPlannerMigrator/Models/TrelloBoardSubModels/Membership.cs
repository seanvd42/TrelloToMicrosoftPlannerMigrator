namespace TrelloToMicrosoftPlannerMigrator.Models.TrelloBoardSubModels
{
    public class Membership
    {
        public string idMember { get; set; }
        public string memberType { get; set; }
        public bool unconfirmed { get; set; }
        public bool deactivated { get; set; }
        public string id { get; set; }
    }


}
