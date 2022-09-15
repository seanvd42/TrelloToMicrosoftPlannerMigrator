using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using TrelloToMicrosoftPlannerMigrator.Models;
using TrelloToMicrosoftPlannerMigrator.Models.TrelloBoardSubModels;
using TrelloToMicrosoftPlannerMigrator.Services;

namespace TrelloToMicrosoftPlannerMigrator.Pages
{
    public class IndexModel : PageModel
    {
        private IMigrationService _migrationService;

        [BindProperty]
        public IFormFile? Upload { get; set; }

        [BindProperty]
        public bool IncludeArchivedLists { get; set; }

        [BindProperty]
        public bool IncludeArchivedCards { get; set; }

        [BindProperty]
        public bool IncludeActions { get; set; }

        [BindProperty]
        public bool IncludeChecklists { get; set; }

        [BindProperty]
        public bool IncludeLabels { get; set; }

        [BindProperty]
        public bool IncludePlaceholder { get; set; }

        public string TestDisplay { get; set; }

        public IndexModel(IMigrationService migrationService)
        {
            _migrationService = migrationService;
            TestDisplay = "";
        }
        
        public void OnPost()
        {
            // Include closed list?
            // Include closed cards?
            if (Upload?.FileName != null)
            {
                using var reader = new StreamReader(Upload.OpenReadStream());
                var board = JsonConvert.DeserializeObject<TrelloBoard>(reader.ReadToEnd()) ?? new TrelloBoard();
                var config = new MigrationConfiguration
                {
                    IncludeArchivedLists = this.IncludeArchivedLists,
                    IncludeArchivedCards = this.IncludeArchivedCards,
                    IncludeActions = this.IncludeActions,
                    IncludeChecklists = this.IncludeChecklists,
                    IncludeLabels = this.IncludeLabels,
                    IncludePlaceholder = this.IncludePlaceholder,
                };
                this.TestDisplay = $"BoardURL: {board.url}\n";
                // Do I need to pass in a microsoft token here? or can I get it in the service?
                _migrationService.MigrateTrelloBoard(board, config);
                //foreach(var actionType in board.actions.GroupBy(x => x.type))
                //    this.TestDisplay += $"{actionType.Key}\n\n";

                foreach (var action in board.cards.Where(x => x.attachments.Any()))
                    this.TestDisplay += $"{JsonConvert.SerializeObject(action.attachments)}\n\n";
                this.TestDisplay += $"\n";
            }
            else
                this.TestDisplay = $"There was an issue parsing the file\n\n";

            this.TestDisplay += 
                $"Include Lists:       {this.IncludeArchivedLists}\n" +
                $"Include Cards:       {this.IncludeArchivedCards}\n" +
                $"Include ACtions:     {this.IncludeActions}\n" +
                $"Include Checklists:  {this.IncludeChecklists}\n" +
                $"Include Labels:      {this.IncludeLabels}\n" +
                $"Include Placeholder: {this.IncludePlaceholder}\n";
        }
    }
}