using SWO.Shared.Classes.Models;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace SWO.Shared.Classes
{
    public class Location : BaseModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        public string? Website { get; set; }

        public string? Description { get; set; }

        public string? Photo { get; set; }

        #region EF
        public virtual List<Simulator>? Simulators { get; set; }
        #endregion
    }
}