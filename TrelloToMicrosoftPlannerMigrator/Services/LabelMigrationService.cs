using TrelloToMicrosoftPlannerMigrator.Models;

namespace TrelloToMicrosoftPlannerMigrator.Services
{
    public interface ILabelMigrationService
    {
        void MigrateLabels(TrelloBoard board);
    }

    public class LabelMigrationService : ILabelMigrationService
    {
        public void MigrateLabels(TrelloBoard board)
        {

        }
    }
}
