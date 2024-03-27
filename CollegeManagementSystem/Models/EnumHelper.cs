using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CollegeManagementSystem.Models
{
    public static class EnumHelper
    {
        public static string? GetDisplayName(Enum value)
        {
            if (value == null)
                return null;

            var field = value.GetType().GetField(value.ToString());
            if (field == null)
                throw new ArgumentException($"Enum field for value '{value}' not found.");

            var attribute = (DisplayAttribute?)Attribute.GetCustomAttribute(field, typeof(DisplayAttribute));
            var displayName = attribute?.Name ?? value.ToString();
            return InsertSpaceBeforeUppercase(displayName);
        }

        private static string InsertSpaceBeforeUppercase(string value)
        {
            if (string.IsNullOrEmpty(value))
                return value;

            var sb = new StringBuilder();
            foreach (char c in value)
            {
                if (char.IsUpper(c))
                    sb.Append(' '); // Insert space before uppercase letter
                sb.Append(c);
            }
            return sb.ToString().Trim(); // Trim any leading/trailing spaces
        }
    }
}
