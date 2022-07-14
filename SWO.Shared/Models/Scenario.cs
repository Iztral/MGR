﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWO.Shared.Models
{
    public class Scenario : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public string? Description { get; set; }

        [ForeignKey("Simulator")]
        [Required]
        public int SimulatorID { get; set; }

        public int MaxGradeSum { get; set; }

        #region EF
        public virtual ICollection<Simulation>? Simulations { get; set; }
        public virtual Simulator Simulator { get; set; }
        public virtual ICollection<ScenarioGradesTemplates>? ScenarioTemplate { get; set; }
        #endregion
    }
}