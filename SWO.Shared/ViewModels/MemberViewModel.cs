using SWO.Shared.Abstractions.Enums;
using SWO.Shared.Abstractions.Models;
using System.ComponentModel.DataAnnotations;

namespace SWO.Shared.Models
{
    public class MemberViewModel : BaseViewModel
    {
        [Required]
        public string IdentityID { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public Role Role { get; set; }

#nullable enable
        public string? Photo { get; set; }

        public string GetFullName() => Name + " " + Surname;

        #region EF
        public virtual ICollection<Simulation>? Simulations { get; set; }
        #endregion
    }
}