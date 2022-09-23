using Microsoft.Graph;
using System.Numerics;
using TrelloToMicrosoftPlannerMigrator.Models;

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
            // Need to get some sort of token probably, maybe do that in the
            //     Index.cshtml.cs file and pass it in?
            var plan = await CreatePlanAsync(board.name);
            var listIDToBucketIDDict = _listMigrationService.MigrateLists(board.lists, plan.ID, includeArchivedLists);
            var labelIDtoCategoryDict = _labelMigrationService.MigrateLabels(board.labels, plan.ID);
            var cardIDToTaskIDDict = _cardMigrationService.MigrateCards(board.cards, plan.ID, listIDToBucketIDDict, labelIDtoCategoryDict, includeArchivedCards);
            var comments = board.actions.Where(x => x.type == "commentCard").ToList();
            _actionMigrationService.MigrateComments(comments);
            _checklistMigrationService.MigrateChecklists(board.checklists);
        }

        public async Task<Plan> CreatePlanAsync(string boardName)
        {
            return new Plan();
            /*
            // How do i determine owner?
            // Need to check if plan exists and if it does create one with number
            var response = await _microsoftGraphAPIService.PostAsync<object>("planner/plans", new
            {
                owner = "09d7497a-661c-43c4-97ed-8ba6834e382f",
                title = boardName
            });
            return await response.Content.ReadFromJsonAsync<Plan>();
            */
        }
    }
}
