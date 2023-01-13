using SWO.Shared.Classes.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWO.Shared.Classes
{
    public class ScenarioGradesTemplates : BaseModel
    {
        [ForeignKey("Scenario")]
        public int ScenarioID { get; set; }

        [ForeignKey("GradeTemplate")]
        public int TemplateID { get; set; }

        public bool Assigned { get; set; }

        public ScenarioGradesTemplates()
        {

        }

        public ScenarioGradesTemplates(int scenarioID, int templateID)
        {
            ScenarioID = scenarioID;
            TemplateID = templateID;
            Assigned = false;
        }

        #region EF
        public virtual Scenario Scenario { get; set; }
        public virtual GradeTemplate GradeTemplate { get; set; }
        #endregion
    }
}