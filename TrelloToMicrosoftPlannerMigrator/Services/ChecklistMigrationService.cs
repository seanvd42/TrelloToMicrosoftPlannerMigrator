using TrelloToMicrosoftPlannerMigrator.Models;

namespace TrelloToMicrosoftPlannerMigrator.Services
{
    public interface IChecklistMigrationService
    {
        void MigrateChecklists(TrelloBoard board);
    }

    public class ChecklistMigrationService : IChecklistMigrationService
    {
        public void MigrateChecklists(TrelloBoard board)
        {

        }
    }
}
