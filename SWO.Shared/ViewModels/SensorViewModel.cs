using SWO.Shared.Abstractions.Enums;
using SWO.Shared.Abstractions.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWO.Shared.Models
{
    public class SensorViewModel : BaseViewModel
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