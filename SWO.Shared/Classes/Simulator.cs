using SWO.Shared.Classes.Enums;
using SWO.Shared.Classes.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWO.Shared.Classes
{
    public class Simulator : BaseModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public SimType Type { get; set; }

        [ForeignKey("Location")]
        [Required]
        public int LocationID { get; set; }

        public string? Photo { get; set; }

        public string? Description { get; set; }

        #region EF
        public virtual Location Location { get; set; }
        public virtual ICollection<Sensor>? Sensors { get; set; }
        public virtual ICollection<GradeTemplate>? GradeTemplates { get; set; }
        public virtual ICollection<Scenario>? Scenarios { get; set; }
        #endregion
    }
}