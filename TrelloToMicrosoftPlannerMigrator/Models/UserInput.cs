using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Graph;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.PortableExecutable;
using TrelloToMicrosoftPlannerMigrator.Models.TrelloBoardSubModels;
using TrelloToMicrosoftPlannerMigrator.Services;

namespace TrelloToMicrosoftPlannerMigrator.Models
{
    public class UserInput
    {
        [Display(Name = "Trello Board File")]
        public IFormFile? TrelloBoardFile { get; set; }

        [Display(Name = "Include archived lists?")]
        public bool IncludeArchivedLists { get; set; }

        [Display(Name = "Include archived cards?")]
        public bool IncludeArchivedCards { get; set; }

        public string TestDisplay { get; set; }
    }
}