using SWO.Shared.Classes.Enums;
using SWO.Shared.Classes.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWO.Shared.Classes
{
    public class Sensor : BaseModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public SensorType Category { get; set; }

        public string? Addendum { get; set; }

        [Required]
        [ForeignKey("Simulator")]
        public int SimulatorID { get; set; }

        #region EF
        public virtual Simulator Simulator { get; set; }
        public virtual ICollection<SensorValue>? SensorValues { get; set; }
        #endregion
    }
}