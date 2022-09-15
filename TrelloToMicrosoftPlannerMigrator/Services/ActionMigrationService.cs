using Action = TrelloToMicrosoftPlannerMigrator.Models.TrelloBoardSubModels.Action;

namespace TrelloToMicrosoftPlannerMigrator.Services
{
    public interface ICommentMigrationService
    {
         void MigrateComments(List<Action> comments);
    }

    public class CommentMigrationService : ICommentMigrationService
    {
        public void MigrateComments(List<Action> comments)
        {

        }
    }
}
