using System.Reflection.Emit;
using TrelloToMicrosoftPlannerMigrator.Models;
using TrelloToMicrosoftPlannerMigrator.Models.TrelloBoardSubModels;

namespace TrelloToMicrosoftPlannerMigrator.Services
{
    public interface ICardMigrationService
    {
        Dictionary<string, string> MigrateCards(List<Card> cards, string planID, Dictionary<string, string> listIDToBucketIDDict, Dictionary<string, int> labelIDtoCategoryDict, bool includeArchivedCards);
    }

    public class CardMigrationService : ICardMigrationService
    {
        public Dictionary<string, string> MigrateCards(List<Card> cards, string planID, Dictionary<string, string> listIDToBucketIDDict, Dictionary<string, int> labelIDtoCategoryDict, bool includeArchivedCards)
        {
            var cardIDToTaskIDDict = new Dictionary<string, string>();
            foreach (var card in cards)
            {
                var taskID = CreateTask(card);
            }
            return cardIDToTaskIDDict;

            string CreateTask(Card card)
            {
                var attachmentIDs = CreateAttachments(card.attachments);
                // Task has label, bucket, progress, priority, start date, due date, notes, checklist, attachments, and comments
                // *label -> label
                // *List -> bucket
                // progress? Maybe
                // Priority? label maybe?
                // *Start dt -> start date
                // *due date -> due date
                // *description -> notes
                // *checklist -> checklist // Will likely have to be done separately
                // *attachments -> attachment
                // comments -> comments

                // Create task in microsoft
                var newID = card.id;
                return newID;
            }
        }

        public Dictionary<string, string> CreateAttachments(List<Attachment> attachments)
        {
            var attachmentIDs = new Dictionary<string, string>();
            foreach (var attachment in attachments)
            {
                // Download attachment
                // Upload to microsoft
                var newID = attachment.id;
                attachmentIDs.Add(attachment.id, newID);
            }
            return attachmentIDs;
        }
    }
}
