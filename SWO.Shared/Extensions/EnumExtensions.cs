using System.ComponentModel;
using System.Reflection;

namespace SWO.Shared.Extensions
{
    public static class EnumExtensions
    {
        public static string GetDescription(this Enum enumValue)
        {
            FieldInfo fi = enumValue.GetType().GetField(enumValue.ToString());
            return fi != null
                ? fi.GetCustomAttributes(
                                    typeof(DescriptionAttribute),
                                    false) is DescriptionAttribute[] attributes &&
                                    attributes.Length > 0
                                    ? attributes[0].Description
                                    : enumValue.ToString()
                : enumValue.ToString();

        }
    }
}
