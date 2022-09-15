using TrelloToMicrosoftPlannerMigrator.Models.TrelloBoardSubModels;

namespace TrelloToMicrosoftPlannerMigrator.Services
{
    public interface IListMigrationService
    {
        Dictionary<string, string> MigrateLists(List<List> lists, string planID, bool includeClosedLists);
    }

    public class ListMigrationService : IListMigrationService
    {
        public Dictionary<string, string> MigrateLists(List<List> lists, string planID, bool includeClosedLists)
        {
            var listOldIDToNewIDDict = new Dictionary<string, string>();
            foreach(var list in lists.Where(x => includeClosedLists || !x.closed))
                    listOldIDToNewIDDict.Add(list.id, CreateBucket(planID, list.name));
            return listOldIDToNewIDDict;
        }

        private string CreateBucket(string planID, string listName)
        {
            return "_new" + listName;
        }
    }
}
