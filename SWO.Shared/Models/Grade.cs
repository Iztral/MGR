using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWO.Shared.Models
{
    public class Grade : BaseEntity
    {
        [ForeignKey("GradeTemplate")]
        [Required]
        public int TemplateID { get; set; }

        [ForeignKey("Simulation")]
        [Required]
        public int SimulationID { get; set; }

        [Required]
        public int Points { get; set; }

        public int TimeTaken { get; set; }

        public string? Addendum { get; set; }

        #region EF
        public virtual Simulation Simulation { get; set; }
        public virtual GradeTemplate GradeTemplate { get; set; }
        #endregion
    }
}
