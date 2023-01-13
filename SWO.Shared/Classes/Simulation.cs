using SWO.Shared.Classes.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWO.Shared.Classes
{
    public class Simulation : BaseModel
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
        public virtual ApplicationUser Trainee { get; set; }
        public virtual ApplicationUser Instructor { get; set; }
        public virtual Scenario Scenario { get; set; }
        public virtual ICollection<Grade>? Grades { get; set; }
        #endregion
    }
}