using System.Text.RegularExpressions;

namespace CodeWarsTests.Tasks
{
    public static class KataExtensionTaks01
    {
        // https://www.codewars.com/kata/567bf4f7ee34510f69000032
        // Regexp Basics - is it a digit?
        // Implement String#digit? (in Java StringUtils.isDigit(String)), which should return true if given object is a digit (0-9), false otherwise.
        public static bool Digit(this string s)
        {
            // return Regex.IsMatch(s, "^([0-9]\\Z)$");
            return Regex.IsMatch(s, "^\\d\\Z$");
        }
    }
}
