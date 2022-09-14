using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using TrelloToMicrosoftPlannerMigrator.Models;

namespace TrelloToMicrosoftPlannerMigrator.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public IFormFile Upload { get; set; }

        [BindProperty]
        public bool IncludeLists { get; set; }

        [BindProperty]
        public bool IncludeCards { get; set; }

        [BindProperty]
        public bool IncludeActions { get; set; }

        [BindProperty]
        public bool IncludeChecklists { get; set; }

        [BindProperty]
        public bool IncludeLabels { get; set; }

        [BindProperty]
        public bool IncludePlaceholder { get; set; }

        public string TestDisplay { get; set; }
        
        public void OnPost()
        {
            if (Upload?.FileName != null)
            {
                string fileContent = null;
                using (var reader = new StreamReader(Upload.OpenReadStream()))
                {
                    fileContent = reader.ReadToEnd();
                }
                var board = JsonConvert.DeserializeObject<TrelloBoard>(fileContent);
                this.TestDisplay = $"BoardURL: {board.url}\n";
            }
            this.TestDisplay += 
                $"Include Lists:       {this.IncludeLists}\n" +
                $"Include Cards:       {this.IncludeCards}\n" +
                $"Include ACtions:     {this.IncludeActions}\n" +
                $"Include Checklists:  {this.IncludeChecklists}\n" +
                $"Include Labels:      {this.IncludeLabels}\n" +
                $"Include Placeholder: {this.IncludePlaceholder}\n";

            // Next step is to use this information and the TrelloBoard object to call services that handle migrating each thing
        }
    }
}