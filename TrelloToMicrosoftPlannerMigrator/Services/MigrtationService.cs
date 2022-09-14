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
        private IActionMigrationService _actionMigrationService;
        private IChecklistMigrationService _checklistMigrationService;
        private ILabelMigrationService _labelMigrationService;
        private IPlaceholderMigrationService _placeholderMigrationService;

        public MigrationService(
            IListMigrationService list, 
            ICardMigrationService card, 
            IActionMigrationService action,
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
            if (config.IncludeLists)
                _listMigrationService.MigrateLists(board);
            if (config.IncludeCards)
                _cardMigrationService.MigrateCards(board);
            if (config.IncludeActions)
                _actionMigrationService.MigrateActions(board);
            if (config.IncludeChecklists)
                _checklistMigrationService.MigrateChecklists(board);
            if (config.IncludeLabels)
                _labelMigrationService.MigrateLabels(board);
            if (config.IncludePlaceholder)
                _placeholderMigrationService.MigratePlaceholders(board);
        }
    }
}
