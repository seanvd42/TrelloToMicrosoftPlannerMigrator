using TrelloToMicrosoftPlannerMigrator.Models;

namespace TrelloToMicrosoftPlannerMigrator.Services
{
    public interface ICardMigrationService
    {
        void MigrateCards(TrelloBoard board);
    }

    public class CardMigrationService : ICardMigrationService
    {
        public void MigrateCards(TrelloBoard board)
        {

        }
    }
}
