using System.Collections.Generic;
using System.Linq;

namespace System.Collections.Extensions
{
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Indicates whether the specified enumerable is null or an empty sequence.
        /// </summary>
        /// <param name="enumerable">The enumerable to test.</param>
        /// <returns>true if the value parameter is null or an empty string (""), otherwise false.</returns>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> enumerable)
        {
            return enumerable == null || !enumerable.Any();
        }

        /// <summary>
        /// Invokes an action for every item of the enumerable.
        /// </summary>
        /// <param name="enumerable">The enumerable.</param>
        /// <param name="action">The action to perform.</param>
        /// <typeparam name="T">The enumerable type.</typeparam>
        /// <returns></returns>
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            foreach (var i in enumerable)
            {
                action(i);
            }

            return enumerable;
        }

        /// <summary>
        /// Casts the enumerable to the specified type and invokes
        /// an action for every item of the enumerable.
        /// </summary>
        /// <param name="enumerable">The enumerable.</param>
        /// <param name="action">The action to perform.</param>
        /// <typeparam name="T">The enumerable type.</typeparam>
        /// <returns></returns>
        public static IEnumerable<T> ForEach<T>(this IEnumerable enumerable, Action<T> action)
        {
            var result = enumerable
                .Cast<T>()
                .ForEach(action);

            return result;
        }

        /// <summary>
        /// Shortcut for foreach and create new list.
        /// </summary>
        /// <param name="enumerable">The enumerable.</param>
        /// <param name="func">The function.</param>
        /// <typeparam name="T">The enumerable type.</typeparam>
        /// <typeparam name="TResult">The result type.</typeparam>
        /// <returns></returns>
        public static IEnumerable<TResult> ForEach<T, TResult>(this IEnumerable<T> enumerable, Func<T, TResult> func)
            where TResult : class
        {
            var result = enumerable
                .Select(func)
                .Where(obj => obj != null);

            return result;
        }
    }
}