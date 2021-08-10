using System.Linq;
using System.Text.RegularExpressions;

namespace KataBenchmarks.RemoveVowel
{
    internal static class RemoveVowelTestMethods
    {
        public static string DisemvowelRegex1(string str)
        {
            return Regex.Replace(str, "[aeiou]", "", RegexOptions.IgnoreCase);
        }

        public static string DisemvowelRegex2(string str)
        {
            return Regex.Replace(str, "[euioa]", "", RegexOptions.IgnoreCase); ;
        }
        public static string DisemvowelLinQ1(string str)
        {
            return string.Concat(str.Where(ch => !"aeiouAEIOU".Contains(ch)));
        }
        public static string DisemvowelLinQ2(string str)
        {
            return new string(str.Where(c => !"aeiuoAEIOU".Contains(c)).ToArray());
        }
    }
}
