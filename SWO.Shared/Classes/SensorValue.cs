using SWO.Shared.Classes.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWO.Shared.Classes
{
    public class SensorValue : BaseModel
    {
        public string Value { get; set; }
        public DateTime TimeStamp { get; set; }

        [Required]
        [ForeignKey("Sensor")]
        public int SensorID { get; set; }

        [Required]
        [ForeignKey("Simulation")]
        public int SimulationID { get; set; }

        #region EF
        public virtual Sensor Sensor { get; set; }
        public virtual Simulation Simulation { get; set; }
        #endregion
    }
}