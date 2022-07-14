using System.ComponentModel.DataAnnotations;

namespace SWO.Shared.Models
{
    public class Location : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string? Address { get; set; }

        public string? Website { get; set; }

        public string? Description { get; set; }

        public string? Photo { get; set; }

        #region EF
        public virtual List<Simulator>? Simulators { get; set; }
        #endregion
    }
}