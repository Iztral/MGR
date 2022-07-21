using SWO.Shared.Abstractions.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWO.Shared.Models
{
    public class ScenarioGradesTemplatesViewModel : BaseViewModel
    {
        public int ScenarioID { get; set; }

        public int TemplateID { get; set; }

        public bool Assigned { get; set; }

        public ScenarioGradesTemplatesViewModel()
        {

        }

        public ScenarioGradesTemplatesViewModel(int scenarioID, int templateID)
        {
            ScenarioID = scenarioID;
            TemplateID = templateID;
            Assigned = false;
        }
    }
}