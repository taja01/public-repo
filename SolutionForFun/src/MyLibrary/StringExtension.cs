using System.Globalization;

namespace MyLibrary
{
    public static class StringExtension
    {
        private const CompareOptions COMPARE_OPTIONS = CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace;

        public static bool ContainsIgnoreCase(this string source, string toCheck)
        {
            var ci = CultureInfo.CurrentCulture.CompareInfo;
            return ci.IndexOf(source, toCheck, COMPARE_OPTIONS) != -1;
        }
    }
}
