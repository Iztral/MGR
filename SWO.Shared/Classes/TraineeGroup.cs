using SWO.Shared.Classes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWO.Shared.Classes
{
    public class TraineeGroup : BaseModel
    {
        [Required]
        public string Name { get; set; }

        #region EF
        public virtual ICollection<ScenarioGradesTemplates>? TreineeAssignments { get; set; }
        #endregion
    }
}
