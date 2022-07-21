using SWO.Shared.Abstractions.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWO.Shared.Models
{
    public class SensorValueViewModel : BaseViewModel
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