using TrelloToMicrosoftPlannerMigrator.Models;

namespace TrelloToMicrosoftPlannerMigrator.Services
{
    public interface IPlaceholderMigrationService
    {
        void MigratePlaceholders(TrelloBoard board);
    }

    public class PlaceholderMigrationService : IPlaceholderMigrationService
    {
        public void MigratePlaceholders(TrelloBoard board)
        {

        }
    }
}
