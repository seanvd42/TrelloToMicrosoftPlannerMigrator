namespace TrelloToMicrosoftPlannerMigrator.Models.TrelloBoardSubModels
{
    public class Action
    {
        public string id { get; set; }
        public string idMemberCreator { get; set; }
        public Data data { get; set; }
        public AppCreator appCreator { get; set; }
        public string type { get; set; }
        public DateTime? date { get; set; }
        public object limits { get; set; }
        public MemberCreator memberCreator { get; set; }
    }


}
