namespace TrelloToMicrosoftPlannerMigrator.Models.TrelloBoardSubModels
{
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


}
