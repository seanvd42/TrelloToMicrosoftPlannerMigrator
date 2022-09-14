using TrelloToMicrosoftPlannerMigrator.Models;

namespace TrelloToMicrosoftPlannerMigrator.Services
{
    public interface IListMigrationService
    {
        void MigrateLists(TrelloBoard board);
    }

    public class ListMigrationService : IListMigrationService
    {
        public void MigrateLists(TrelloBoard board)
        {

        }
    }
}
