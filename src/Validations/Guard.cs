namespace System.Extensions.Guard
{
    public static class Guard
    {
        public static T NotNull<T>(this T instance,
            [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
            [System.Runtime.CompilerServices.CallerFilePath] string sourceFilePath = "",
            [System.Runtime.CompilerServices.CallerLineNumber] int sourceLineNumber = 0)
        {
            if (instance == null)
            {
                throw new ArgumentNullException($"{memberName} {sourceFilePath}:{sourceLineNumber}");
            }
            return instance;
        }

        public static string NotNull(this string instance,
            [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
            [System.Runtime.CompilerServices.CallerFilePath] string sourceFilePath = "",
            [System.Runtime.CompilerServices.CallerLineNumber] int sourceLineNumber = 0)
        {
            if (instance.IsNullOrEmpty())
            {
                throw new ArgumentNullException($"{memberName} {sourceFilePath}:{sourceLineNumber}");
            }
            return instance;
        }
    }
}
