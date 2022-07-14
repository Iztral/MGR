﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWO.Shared.Models
{
    public class Simulation : BaseEntity
    {
        [ForeignKey("Trainee")]
        [Required]
        public int TraineeID { get; set; }

        [ForeignKey("Instructor")]
        [Required]
        public int InstructorID { get; set; }

        [ForeignKey("Scenario")]
        [Required]
        public int ScenarioID { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public int GradeSum { get; set; }

        #region EF
        public virtual User Trainee { get; set; }
        public virtual User Instructor { get; set; }
        public virtual Scenario Scenario { get; set; }
        public virtual ICollection<Grade>? Grades { get; set; }
        #endregion
    }
}