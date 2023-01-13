using SWO.Shared.Classes.Models;

namespace SWO.Shared.Classes.ViewModels
{
    public class GradeViewModel : BaseModel
    {
        public int TemplateID { get; set; }

        public int Points { get; set; }

        public int TimeTaken { get; set; }

        public string? Addendum { get; set; }
    }
}
