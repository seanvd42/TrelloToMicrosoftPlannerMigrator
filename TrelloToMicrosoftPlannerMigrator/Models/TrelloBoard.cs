using System.Reflection.Emit;

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

    public class AppCreator
    {
        public string id { get; set; }
    }

    public class Attachments
    {
        public PerBoard perBoard { get; set; }
        public PerCard perCard { get; set; }
    }

    public class AttachmentsByType
    {
        public Trello trello { get; set; }
    }

    public class BackgroundImageScaled
    {
        public int width { get; set; }
        public int height { get; set; }
        public string url { get; set; }
    }

    public class Badges
    {
        public AttachmentsByType attachmentsByType { get; set; }
        public bool location { get; set; }
        public int votes { get; set; }
        public bool viewingMemberVoted { get; set; }
        public bool subscribed { get; set; }
        public string fogbugz { get; set; }
        public int checkItems { get; set; }
        public int checkItemsChecked { get; set; }
        public object checkItemsEarliestDue { get; set; }
        public int comments { get; set; }
        public int attachments { get; set; }
        public bool description { get; set; }
        public DateTime? due { get; set; }
        public bool dueComplete { get; set; }
        public object start { get; set; }
    }

    public class BioData
    {
        public Emoji emoji { get; set; }
    }

    public class Board
    {
        public string id { get; set; }
        public string name { get; set; }
        public string shortLink { get; set; }
    }

    public class Boards
    {
        public TotalMembersPerBoard totalMembersPerBoard { get; set; }
        public TotalAccessRequestsPerBoard totalAccessRequestsPerBoard { get; set; }
    }

    public class Card
    {
        public string id { get; set; }
        public string name { get; set; }
        public int idShort { get; set; }
        public string shortLink { get; set; }
        public DateTime? due { get; set; }
        public double? pos { get; set; }
        public bool? closed { get; set; }
        public string desc { get; set; }
    }

    public class Card2
    {
        public string id { get; set; }
        public object address { get; set; }
        public Badges badges { get; set; }
        public object checkItemStates { get; set; }
        public bool closed { get; set; }
        public object coordinates { get; set; }
        public object creationMethod { get; set; }
        public bool dueComplete { get; set; }
        public DateTime? dateLastActivity { get; set; }
        public string desc { get; set; }
        public DescData descData { get; set; }
        public DateTime? due { get; set; }
        public int? dueReminder { get; set; }
        public string email { get; set; }
        public string idBoard { get; set; }
        public List<string> idChecklists { get; set; }
        public List<object> idLabels { get; set; }
        public string idList { get; set; }
        public List<object> idMembers { get; set; }
        public List<object> idMembersVoted { get; set; }
        public int idShort { get; set; }
        public object idAttachmentCover { get; set; }
        public List<object> labels { get; set; }
        public object limits { get; set; }
        public object locationName { get; set; }
        public bool manualCoverAttachment { get; set; }
        public string name { get; set; }
        public double pos { get; set; }
        public string shortLink { get; set; }
        public string shortUrl { get; set; }
        public object staticMapUrl { get; set; }
        public object start { get; set; }
        public bool subscribed { get; set; }
        public string url { get; set; }
        public Cover cover { get; set; }
        public bool isTemplate { get; set; }
        public object cardRole { get; set; }
        public List<object> attachments { get; set; }
        public List<object> pluginData { get; set; }
        public List<object> customFieldItems { get; set; }
        public OpenPerBoard openPerBoard { get; set; }
        public OpenPerList openPerList { get; set; }
        public TotalPerBoard totalPerBoard { get; set; }
        public TotalPerList totalPerList { get; set; }
    }

    public class CheckItem
    {
        public string id { get; set; }
        public string name { get; set; }
        public string state { get; set; }
        public TextData textData { get; set; }
    }

    public class CheckItem2
    {
        public string id { get; set; }
        public string name { get; set; }
        public NameData nameData { get; set; }
        public double pos { get; set; }
        public object due { get; set; }
        public object idMember { get; set; }
        public string idChecklist { get; set; }
        public string state { get; set; }
        public PerChecklist perChecklist { get; set; }
    }

    public class Checklist
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Checklist2
    {
        public string id { get; set; }
        public string name { get; set; }
        public string idBoard { get; set; }
        public string idCard { get; set; }
        public int pos { get; set; }
        public object limits { get; set; }
        public object creationMethod { get; set; }
        public List<CheckItem> checkItems { get; set; }
        public PerBoard perBoard { get; set; }
        public PerCard perCard { get; set; }
    }

    public class Cover
    {
        public object idAttachment { get; set; }
        public object color { get; set; }
        public object idUploadedBackground { get; set; }
        public string size { get; set; }
        public string brightness { get; set; }
        public object idPlugin { get; set; }
    }

    public class CustomFieldOptions
    {
        public PerField perField { get; set; }
    }

    public class CustomFields
    {
        public PerBoard perBoard { get; set; }
    }

    public class Data
    {
        public Card card { get; set; }
        public Checklist checklist { get; set; }
        public Board board { get; set; }
        public Old old { get; set; }
        public List list { get; set; }
        public CheckItem checkItem { get; set; }
        public string text { get; set; }
        public TextData textData { get; set; }
    }

    public class DescData
    {
        public Emoji emoji { get; set; }
    }

    public class Emoji
    {
    }

    public class Label
    {
        public string id { get; set; }
        public string idBoard { get; set; }
        public string name { get; set; }
        public string color { get; set; }
        public PerBoard perBoard { get; set; }
    }

    public class LabelNames
    {
        public string green { get; set; }
        public string yellow { get; set; }
        public string orange { get; set; }
        public string red { get; set; }
        public string purple { get; set; }
        public string blue { get; set; }
        public string sky { get; set; }
        public string lime { get; set; }
        public string pink { get; set; }
        public string black { get; set; }
        public string green_dark { get; set; }
        public string yellow_dark { get; set; }
        public string orange_dark { get; set; }
        public string red_dark { get; set; }
        public string purple_dark { get; set; }
        public string blue_dark { get; set; }
        public string sky_dark { get; set; }
        public string lime_dark { get; set; }
        public string pink_dark { get; set; }
        public string black_dark { get; set; }
        public string green_light { get; set; }
        public string yellow_light { get; set; }
        public string orange_light { get; set; }
        public string red_light { get; set; }
        public string purple_light { get; set; }
        public string blue_light { get; set; }
        public string sky_light { get; set; }
        public string lime_light { get; set; }
        public string pink_light { get; set; }
        public string black_light { get; set; }
    }

    public class List
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Member
    {
        public string id { get; set; }
        public string aaId { get; set; }
        public bool activityBlocked { get; set; }
        public string avatarHash { get; set; }
        public string avatarUrl { get; set; }
        public string bio { get; set; }
        public BioData bioData { get; set; }
        public bool confirmed { get; set; }
        public string fullName { get; set; }
        public object idEnterprise { get; set; }
        public List<object> idEnterprisesDeactivated { get; set; }
        public object idMemberReferrer { get; set; }
        public List<object> idPremOrgsAdmin { get; set; }
        public string initials { get; set; }
        public string memberType { get; set; }
        public NonPublic nonPublic { get; set; }
        public bool nonPublicAvailable { get; set; }
        public List<object> products { get; set; }
        public string url { get; set; }
        public string username { get; set; }
        public string status { get; set; }
    }

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

    public class Membership
    {
        public string idMember { get; set; }
        public string memberType { get; set; }
        public bool unconfirmed { get; set; }
        public bool deactivated { get; set; }
        public string id { get; set; }
    }

    public class NameData
    {
        public Emoji emoji { get; set; }
    }

    public class NonPublic
    {
        public string fullName { get; set; }
        public string initials { get; set; }
        public object avatarHash { get; set; }
    }

    public class Old
    {
        public DateTime? due { get; set; }
        public double? pos { get; set; }
        public bool? closed { get; set; }
        public string desc { get; set; }
    }

    public class OpenPerBoard
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class OpenPerList
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class PerAction
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class PerBoard
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class PerCard
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class PerChecklist
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class PerField
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class Prefs
    {
        public string permissionLevel { get; set; }
        public bool hideVotes { get; set; }
        public string voting { get; set; }
        public string comments { get; set; }
        public string invitations { get; set; }
        public bool selfJoin { get; set; }
        public bool cardCovers { get; set; }
        public bool isTemplate { get; set; }
        public string cardAging { get; set; }
        public bool calendarFeedEnabled { get; set; }
        public List<object> hiddenPluginBoardButtons { get; set; }
        public List<SwitcherView> switcherViews { get; set; }
        public string background { get; set; }
        public object backgroundColor { get; set; }
        public string backgroundImage { get; set; }
        public List<BackgroundImageScaled> backgroundImageScaled { get; set; }
        public bool backgroundTile { get; set; }
        public string backgroundBrightness { get; set; }
        public string backgroundBottomColor { get; set; }
        public string backgroundTopColor { get; set; }
        public bool canBePublic { get; set; }
        public bool canBeEnterprise { get; set; }
        public bool canBeOrg { get; set; }
        public bool canBePrivate { get; set; }
        public bool canInvite { get; set; }
    }

    public class Reactions
    {
        public PerAction perAction { get; set; }
        public UniquePerAction uniquePerAction { get; set; }
    }

    public class Stickers
    {
        public PerCard perCard { get; set; }
    }

    public class SwitcherView
    {
        public string _id { get; set; }
        public string viewType { get; set; }
        public bool enabled { get; set; }
    }

    public class TextData
    {
        public Emoji emoji { get; set; }
    }

    public class TotalAccessRequestsPerBoard
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class TotalMembersPerBoard
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class TotalPerBoard
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class TotalPerList
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class Trello
    {
        public int board { get; set; }
        public int card { get; set; }
    }

    public class UniquePerAction
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }


}
