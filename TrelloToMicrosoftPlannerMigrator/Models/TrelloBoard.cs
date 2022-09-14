using TrelloToMicrosoftPlannerMigrator.Models.TrelloBoardSubModels;
using Action = TrelloToMicrosoftPlannerMigrator.Models.TrelloBoardSubModels.Action;

namespace TrelloToMicrosoftPlannerMigrator.Models
{
    public class TrelloBoard
    {
        public string id { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public object descData { get; set; }
        public bool closed { get; set; }
        public object dateClosed { get; set; }
        public string idOrganization { get; set; }
        public object idEnterprise { get; set; }
        public object limits { get; set; }
        public bool pinned { get; set; }
        public bool starred { get; set; }
        public string url { get; set; }
        public Prefs prefs { get; set; }
        public string shortLink { get; set; }
        public bool subscribed { get; set; }
        public LabelNames labelNames { get; set; }
        public List<object> powerUps { get; set; }
        public DateTime? dateLastActivity { get; set; }
        public DateTime? dateLastView { get; set; }
        public string shortUrl { get; set; }
        public List<object> idTags { get; set; }
        public object datePluginDisable { get; set; }
        public string creationMethod { get; set; }
        public string ixUpdate { get; set; }
        public object templateGallery { get; set; }
        public bool enterpriseOwned { get; set; }
        public object idBoardSource { get; set; }
        public List<string> premiumFeatures { get; set; }
        public string idMemberCreator { get; set; }
        public List<Action> actions { get; set; }
        public List<Card> cards { get; set; }
        public List<Label> labels { get; set; }
        public List<List> lists { get; set; }
        public List<Member> members { get; set; }
        public List<Checklist> checklists { get; set; }
        public List<object> customFields { get; set; }
        public List<Membership> memberships { get; set; }
        public List<object> pluginData { get; set; }
    }
}
