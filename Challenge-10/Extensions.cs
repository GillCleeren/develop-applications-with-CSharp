using System.ComponentModel;
using System.Reflection;

namespace CarvedRock.Backend
{
    internal static class Extensions
    {
        public static string GetDescription(this Enum enumValue)
        {
            Type type = enumValue.GetType();
            string enumerationName = Enum.GetName(type, enumValue);

            if (enumerationName != null)
            {
                FieldInfo field = type.GetField(enumerationName);
                if (field != null)
                {
                    DescriptionAttribute attr = Attribute.GetCustomAttribute(field,typeof(DescriptionAttribute)) as DescriptionAttribute;
                    if (attr != null)
                    {
                        return attr.Description;
                    }
                }
            }
            return enumValue.ToString();
        }
    }
}
