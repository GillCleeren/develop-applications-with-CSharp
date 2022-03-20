using System.ComponentModel;
using System.Reflection;

namespace CarvedRock.Backend
{
    internal static class Extensions
    {
        public static string GetDescription(this Enum enumValue)
        {
            Type type = enumValue.GetType();
            string enumerationValueName = Enum.GetName(type, enumValue);

            if (enumerationValueName != null)
            {
                FieldInfo field = type.GetField(enumerationValueName);
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
