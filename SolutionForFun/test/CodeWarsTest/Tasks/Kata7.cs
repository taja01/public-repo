using System.Text.RegularExpressions;

namespace CodeWarsTests.Tasks
{
    public partial class Kata
    {
        //Create a function called shortcut to remove all the lowercase vowels in a given string.
        public static string Shortcut(string input)
        {
            //var vowels = "aeiou";
            //return new string(input.Where(c => !vowels.Contains(c)).ToArray());

            return Regex.Replace(input, "[aiuoe]", "");
        }
    }
}
