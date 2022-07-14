using SWO.Shared.Extensions;
using SWO.Shared.Resources;

namespace SWO.Shared.Abstractions.Enums
{
    public enum Role
    {
        [LocalizedDescription("Admin", typeof(EnumResources))]
        Admin,
        [LocalizedDescription("Instructor", typeof(EnumResources))]
        Instructor,
        [LocalizedDescription("Trainee", typeof(EnumResources))]
        Trainee,
        [LocalizedDescription("All", typeof(EnumResources))]
        All = -1
    };
}