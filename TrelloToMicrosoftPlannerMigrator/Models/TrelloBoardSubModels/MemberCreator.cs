namespace TrelloToMicrosoftPlannerMigrator.Models.TrelloBoardSubModels
{
    public class MemberCreator
    {
        public string id { get; set; }
        public bool activityBlocked { get; set; }
        public string avatarHash { get; set; }
        public string avatarUrl { get; set; }
        public string fullName { get; set; }
        public object idMemberReferrer { get; set; }
        public string initials { get; set; }
        public NonPublic nonPublic { get; set; }
        public bool nonPublicAvailable { get; set; }
        public string username { get; set; }
    }


}
