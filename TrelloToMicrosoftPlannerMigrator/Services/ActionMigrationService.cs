using TrelloToMicrosoftPlannerMigrator.Models;

namespace TrelloToMicrosoftPlannerMigrator.Services
{
    public interface IActionMigrationService
    {
        void MigrateActions(TrelloBoard board);
    }

    public class ActionMigrationService : IActionMigrationService
    {
        public void MigrateActions(TrelloBoard board)
        {

        }
    }
}
