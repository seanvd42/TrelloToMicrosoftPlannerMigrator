namespace TrelloToMicrosoftPlannerMigrator.Models.TrelloBoardSubModels
{
    public class Attachment
    {
        public int bytes { get; set; }
        public DateTime date { get; set; }
        public object edgeColor { get; set; }
        public string idMember { get; set; }
        public bool isUpload { get; set; }
        public string mimeType { get; set; }
        public string name { get; set; }
        public List<object> previews { get; set; }
        public string url { get; set; }
        public int pos { get; set; }
        public string fileName { get; set; }
        public string id { get; set; }
    }


}
