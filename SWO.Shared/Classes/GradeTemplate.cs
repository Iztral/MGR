using SWO.Shared.Classes.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWO.Shared.Classes
{
    public class GradeTemplate : BaseModel
    {
        [Required]
        public string Name { get; set; }

        public string? Description { get; set; }

        [Required]
        public int MaxPoints { get; set; }

        [ForeignKey("Simulator")]
        [Required]
        public int SimulatorID { get; set; }

        public string? Note { get; set; }

        public int? Phase { get; set; }

        public int OptimalTime { get; set; }

        #region EF
        public virtual Simulator Simulator { get; set; }
        public virtual ICollection<Grade>? Grades { get; set; }
        public virtual ICollection<ScenarioGradesTemplates>? ScenarioTemplate { get; set; }
        #endregion
    }
}