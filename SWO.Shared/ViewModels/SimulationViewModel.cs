using SWO.Shared.Abstractions.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWO.Shared.Models
{
    public class SimulationViewModel : BaseViewModel
    {
        [ForeignKey("Trainee")]
        [Required]
        public int TraineeID { get; set; }

        [ForeignKey("Instructor")]
        [Required]
        public int InstructorID { get; set; }

        [ForeignKey("Scenario")]
        [Required]
        public int ScenarioID { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public int GradeSum { get; set; }

        #region EF
        public virtual Member Trainee { get; set; }
        public virtual Member Instructor { get; set; }
        public virtual Scenario Scenario { get; set; }
        public virtual ICollection<Grade>? Grades { get; set; }
        #endregion
    }
}