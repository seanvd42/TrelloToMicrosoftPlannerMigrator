namespace TrelloToMicrosoftPlannerMigrator.Models
{
    public class Plan
    {
        public DateTime CreatedDateTime { get; set; }
        public string Owner { get; set; }
        public string Title { get; set; }
        public string ID { get; set; }
        public CreatedBy CreatedBy { get; set; }
        public Container Container { get; set; }

    }

    public class Application
    {
        public object DisplayName { get; set; }
        public string ID { get; set; }
    }

    public class Container
    {
        public string ContainerId { get; set; }
        public string Type { get; set; }
        public string Url { get; set; }
    }

    public class CreatedBy
    {
        public User User { get; set; }
        public Application Application { get; set; }
    }

    public class User
    {
        public object DisplayName { get; set; }
        public string ID { get; set; }
    }
}
