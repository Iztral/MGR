using SWO.Shared.Extensions;
using SWO.Shared.Resources;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWO.Shared.Classes.Models
{
    public class BaseModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [LocalizedDescription("Id", typeof(ModelResources))]
        public Guid Id { get; set; }
    }
}
