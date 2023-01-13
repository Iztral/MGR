using SWO.Shared.Classes.Models;

namespace SWO.Shared.Classes.ViewModels
{
    public class SensorValueViewModel : BaseModel
    {
        public string Value { get; set; }

        public DateTime TimeStamp { get; set; }

        public int SensorID { get; set; }
    }
}
