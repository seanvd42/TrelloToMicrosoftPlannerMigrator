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
                this.TestDisplay = $"BoardURL: {board.url}\n";
                // Do I need to pass in a microsoft token here? or can I get it in the service?
                _migrationService.MigrateTrelloBoard(board, this.IncludeArchivedLists, this.IncludeArchivedCards);
            }
            else
                this.TestDisplay = $"There was an issue parsing the file\n\n";

            this.TestDisplay += 
                $"Include Lists:       {this.IncludeArchivedLists}\n" +
                $"Include Cards:       {this.IncludeArchivedCards}\n";
        }
    }
}