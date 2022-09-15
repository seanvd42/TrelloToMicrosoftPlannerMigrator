using TrelloToMicrosoftPlannerMigrator.Models;
using TrelloToMicrosoftPlannerMigrator.Models.TrelloBoardSubModels;

namespace TrelloToMicrosoftPlannerMigrator.Services
{
    public interface IChecklistMigrationService
    {
        void MigrateChecklists(List<Checklist> checklists);
    }

    public class ChecklistMigrationService : IChecklistMigrationService
    {
        public void MigrateChecklists(List<Checklist> checklists)
        {

        }
    }
}
