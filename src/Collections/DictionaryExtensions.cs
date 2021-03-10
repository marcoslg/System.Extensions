namespace System.Collections.Generic.Extensions
{
    public static class DictionaryExtensions
    {
        /// <summary>
        /// Gets the value securely.
        /// </summary>
        /// <param name="dictionary">The dictionary.</param>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        public static string GetValueSecure(this IDictionary<string, string> dictionary, string key)
        {
            if (dictionary == null || dictionary.Count == 0)
            {
                return string.Empty;
            }

            var containsValue = dictionary.TryGetValue(key, out var result);
            return containsValue
                ? result
                : string.Empty;
        }
    }
}