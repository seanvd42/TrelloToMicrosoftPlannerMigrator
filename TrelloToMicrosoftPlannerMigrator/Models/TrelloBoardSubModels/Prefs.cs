namespace TrelloToMicrosoftPlannerMigrator.Models.TrelloBoardSubModels
{
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


}
