using Microsoft.Graph;
using System.Numerics;
using TrelloToMicrosoftPlannerMigrator.Models;
using TrelloToMicrosoftPlannerMigrator.Models.TrelloBoardSubModels;

namespace TrelloToMicrosoftPlannerMigrator.Services
{
    public interface IMigrationService
    {
        Task MigrateTrelloBoardAsync(TrelloBoard board, bool includeArchivedLists, bool includeArchivedCards);
    }

    public class MigrationService : IMigrationService
    {
        private IListMigrationService _listMigrationService;
        private ICardMigrationService _cardMigrationService;
        private ICommentMigrationService _actionMigrationService;
        private IChecklistMigrationService _checklistMigrationService;
        private ILabelMigrationService _labelMigrationService;
        private readonly GraphServiceClient _graphServiceClient;

        public MigrationService(
            IListMigrationService list, 
            ICardMigrationService card, 
            ICommentMigrationService action,
            IChecklistMigrationService checklist,
            ILabelMigrationService labels,
            GraphServiceClient graphServiceClient)
        {
            _listMigrationService = list;
            _cardMigrationService = card;
            _actionMigrationService = action;
            _checklistMigrationService = checklist;
            _labelMigrationService = labels;
            _graphServiceClient = graphServiceClient;
        }
        public async Task MigrateTrelloBoardAsync(TrelloBoard board, bool includeArchivedLists, bool includeArchivedCards)
        {
            var plan = await CreatePlanAsync(board.name);
            var listIDToBucketIDDict = _listMigrationService.MigrateLists(board.lists, plan.Id, includeArchivedLists);
            var labelIDtoCategoryDict = _labelMigrationService.MigrateLabels(board.labels, plan.Id);
            var cardIDToTaskIDDict = _cardMigrationService.MigrateCards(board.cards, plan.Id, listIDToBucketIDDict, labelIDtoCategoryDict, includeArchivedCards);
            var comments = board.actions.Where(x => x.type == "commentCard").ToList();
            _actionMigrationService.MigrateComments(comments);
            _checklistMigrationService.MigrateChecklists(board.checklists);
        }

        public async Task<PlannerPlan> CreatePlanAsync(string boardName)
        {
            var groups = await _graphServiceClient.Groups
                .Request()
                .GetAsync();
            var group = groups.First(x => x.MailEnabled ?? false);

            // If plan title in use add number to end
            var plans = await _graphServiceClient.Groups[group.Id].Planner.Plans
                .Request()
                .GetAsync();
            var appendNum = 1;
            var newBoardName = boardName;
            while(plans.Any(x => x.Title == newBoardName))
                newBoardName = boardName += appendNum++;
            boardName = newBoardName;

            // Create new plan
            var newPlan = new PlannerPlan
            {
                Title = boardName,
                Owner = group.Id,
            };
            return await _graphServiceClient.Planner.Plans.Request().AddAsync(newPlan);
        }
    }
}
