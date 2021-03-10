using System.Globalization;
using System.Linq;
using System.Text;

namespace System.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Transforms the string by upper-casing the first character
        /// of each word and lower-casing the rest, separated by the specified separator.
        /// </summary>
        /// <param name="value">The text to transform.</param>
        /// <param name="separator">The separator character.</param>
        /// <returns></returns>
        public static string ToUpperFirstCharForEveryWord(this string value, char separator = ' ')
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                var builder = new StringBuilder();
                var words = value.ToLower().Split(separator);
                for (var i = 0; i < words.Length; i++)
                {
                    var word = words[i];
                    builder.Append(word.ToUpperFirstCharacter());

                    if (i != word.Length - 1)
                    {
                        builder.Append(separator);
                    }
                }

                return builder.ToString();
            }

            return string.Empty;
        }

        /// <summary>
        /// Transforms the string by upper-casing the first character and
        /// the lower-casing the rest.
        /// </summary>
        /// <param name="value">The text to transform.</param>
        /// <returns></returns>
        public static string ToUpperFirstCharacter(this string value)
        {
            if (value.IsNullOrEmpty())
            {
                return string.Empty;
            }

            var letters = value.ToLower().ToCharArray();
            if (letters.Any())
            {
                letters[0] = char.ToUpper(letters[0]);
            }

            return new string(letters);
        }

        /// <summary>
        /// Parses securely the string to a nullable double.
        /// </summary>
        /// <param name="value">The text to convert.</param>
        /// <returns>If it's valid returns the string converted to a nullable double, otherwise null.</returns>
        public static double? ToTryDouble(this string value)
        {
            if (double.TryParse(value, out var result))
            {
                return result;
            }

            return null;
        }

        /// <summary>
        /// Parses securely the string to the specified generic type.
        /// </summary>
        /// <param name="value">The text to transform.</param>
        /// <typeparam name="T">The type to transform.</typeparam>
        /// <returns>The string converted to the specified type, otherwise null.</returns>
        public static T? GetValueOrNull<T>(this string value)
            where T : struct
        {
            if (value.IsNullOrEmpty() || value == "0")
            {
                return null;
            }

            return (T) Convert.ChangeType(value, typeof(T));
        }

        /// <summary>
        /// Removes all the diacritics from the specified text.
        /// </summary>
        /// <param name="value">The string to transform.</param>
        /// <returns>The string without diacritics.</returns>
        public static string RemoveDiacritics(this string value)
        {
            var normalizedString = value.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var character in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(character);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(character);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }

        /// <summary>
        /// Indicates whether the specified string is null or an empty string.
        /// </summary>
        /// <param name="value">The string to test.</param>
        /// <returns>true if the value parameter is null or an empty string (""), otherwise false.</returns>
        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }
    }
}