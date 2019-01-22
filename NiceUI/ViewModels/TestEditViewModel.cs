using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NiceUI.ViewModels
{
    public class TestEditViewModel
    {
        public TestEditViewModel()
        {
            LopGruppGoals = new List<string>();
        }
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Range(1920,2020)]
        public int Year { get; set; }

        public List<SelectListItem> Groups { get; set; }
        public string SelectedGroup { get; set; }

        public List<SelectListItem> AvailableLopGruppGoals { get; set; }
        public List<string> LopGruppGoals { get; set; }

        public string WriteGoalsForStrengthTraining { get; set; }
    }
}
