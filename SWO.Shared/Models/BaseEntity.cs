using SWO.Shared.Extensions;
using SWO.Shared.Resources;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWO.Shared.Models
{
    public class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [LocalizedDescription("ID", typeof(ModelResources))]
        public int Id { get; set; }
    }
}
