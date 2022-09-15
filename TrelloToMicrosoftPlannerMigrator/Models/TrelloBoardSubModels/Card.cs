using System.Net.Mail;

namespace TrelloToMicrosoftPlannerMigrator.Models.TrelloBoardSubModels
{
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
        public List<Attachment> attachments { get; set; }
    }


}
