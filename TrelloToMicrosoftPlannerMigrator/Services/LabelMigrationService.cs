using TrelloToMicrosoftPlannerMigrator.Models.TrelloBoardSubModels;

namespace TrelloToMicrosoftPlannerMigrator.Services
{
    public interface ILabelMigrationService
    {
        Dictionary<string, int> MigrateLabels(List<Label> labels, string planID);
    }

    public class LabelMigrationService : ILabelMigrationService
    {
        private const int MAX_LABELS = 25;
        public Dictionary<string, int> MigrateLabels(List<Label> labels, string planID)
        {
            if (labels.Count > MAX_LABELS)
                throw new Exception($"Too many labels to be migrated. Can old migrate up to {MAX_LABELS} different labels.");
            // TODO: Labels seem to be categories. Not really sure how to use them.
            //     Seems there are values for category1 - category25. Maybe 
            //     throw error if there are more than 25 and then try to map
            //     to color or something? That's if no api can be found

            // For now just assigning them at random
            var labelIDtoCategoryDict = new Dictionary<string, int>();
            for (int i = 0; i < labels.Count; i++)
                labelIDtoCategoryDict.Add(labels[i].id, i + 1);
            return labelIDtoCategoryDict;
        }
    }
}
