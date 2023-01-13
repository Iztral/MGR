namespace SWO.Shared.Classes.ViewModels
{
    public class SimulationViewModel
    {
        public int TraineeID { get; set; }

        public int InstructorID { get; set; }

        public int ScenarioID { get; set; }

        public int SimulatorID { get; set; }

        public int LocationID { get; set; }

        public DateTime Date { get; set; }

        public List<SensorValueViewModel> SensorValues { get; set; }

        public List<GradeViewModel> Grades { get; set; }

    }
}
