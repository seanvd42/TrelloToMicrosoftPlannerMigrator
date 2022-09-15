using TrelloToMicrosoftPlannerMigrator.Models;

namespace TrelloToMicrosoftPlannerMigrator.Services
{
    public interface IMigrationService
    {
        void MigrateTrelloBoard(TrelloBoard board, MigrationConfiguration config);
    }

    public class MigrationService : IMigrationService
    {
        private IListMigrationService _listMigrationService;
        private ICardMigrationService _cardMigrationService;
        private ICommentMigrationService _actionMigrationService;
        private IChecklistMigrationService _checklistMigrationService;
        private ILabelMigrationService _labelMigrationService;
        private IPlaceholderMigrationService _placeholderMigrationService;

        public MigrationService(
            IListMigrationService list, 
            ICardMigrationService card, 
            ICommentMigrationService action,
            IChecklistMigrationService checklist,
            ILabelMigrationService labels,
            IPlaceholderMigrationService placeholder)
        {
            _listMigrationService = list;
            _cardMigrationService = card;
            _actionMigrationService = action;
            _checklistMigrationService = checklist;
            _labelMigrationService = labels;
            _placeholderMigrationService = placeholder;
        }
        public void MigrateTrelloBoard(TrelloBoard board, MigrationConfiguration config)
        {
            // Need to get some sort of token probably, maybe do that in the
            //     Index.cshtml.cs file and pass it in?
            var planID = CreatePlan(board.name);
            var listIDToBucketIDDict = _listMigrationService.MigrateLists(board.lists, planID, config.IncludeArchivedLists);
            var labelIDtoCategoryDict = _labelMigrationService.MigrateLabels(board.labels, planID);
            var cardIDToTaskIDDict = _cardMigrationService.MigrateCards(board.cards, planID, listIDToBucketIDDict, labelIDtoCategoryDict, config.IncludeArchivedCards);
            var comments = board.actions.Where(x => x.type == "commentCard").ToList();
            _actionMigrationService.MigrateComments(comments);
            _checklistMigrationService.MigrateChecklists(board.checklists);
        }

        public string CreatePlan(string boardName)
        {
            // How do i determine owner?
            // Need to check if plan exists and if it does create one with number
            return "_newIDFor_" + boardName;
        }
    }
}
