using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Graph;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using TrelloToMicrosoftPlannerMigrator.Models;
using TrelloToMicrosoftPlannerMigrator.Models.TrelloBoardSubModels;
using TrelloToMicrosoftPlannerMigrator.Services;

namespace TrelloToMicrosoftPlannerMigrator.Views.Home
{
    public class IndexModel : PageModel
    {
        private IMigrationService _migrationService;
        private readonly GraphServiceClient _graphServiceClient;

        [BindProperty]
        public IFormFile? Upload { get; set; }

        [BindProperty]
        public bool IncludeArchivedLists { get; set; }

        [BindProperty]
        public bool IncludeArchivedCards { get; set; }

        public string TestDisplay { get; set; }

        public IndexModel(
            IMigrationService migrationService,
            GraphServiceClient graphServiceClient)
        {
            _migrationService = migrationService;
            _graphServiceClient = graphServiceClient;
            TestDisplay = "";
        }

        public async Task OnPostAsync()
        {
            if (Upload?.FileName != null)
            {
                using var reader = new StreamReader(Upload.OpenReadStream());
                var board = JsonConvert.DeserializeObject<TrelloBoard>(reader.ReadToEnd()) ?? new TrelloBoard();
                TestDisplay = $"BoardURL: {board.url}\n";
                await _migrationService.MigrateTrelloBoardAsync(board, IncludeArchivedLists, IncludeArchivedCards);
            }
            else
                TestDisplay = $"There was an issue parsing the file\n\n";

            var plans = await _graphServiceClient.Me.Planner.Plans.Request().GetAsync();
            ViewData["Plans"] = plans.Select(x => x.Title).ToList();
            TestDisplay +=
                $"Include Lists:       {IncludeArchivedLists}\n" +
                $"Include Cards:       {IncludeArchivedCards}\n";
        }
    }
}