using SWO.Shared.Extensions;
using SWO.Shared.Resources;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWO.Shared.Abstractions.Models
{
    public class BaseModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [LocalizedDescription("ID", typeof(ModelResources))]
        public int Id { get; set; }
    }
}
