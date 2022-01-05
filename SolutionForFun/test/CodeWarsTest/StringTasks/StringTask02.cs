using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWarsTests.StringTasks
{
    public partial class Kata
    {
        /*
         * https://www.codewars.com/kata/53af2b8861023f1d88000832
         * Create a function which answers the question "Are you playing banjo?".
         * If your name starts with the letter "R" or lower case "r", you are playing banjo!
         * The function takes a name as its only argument, and returns one of the following strings:
         * name + " plays banjo" 
         * name + " does not play banjo"
         * Names given are always valid strings.
         */
        public static string AreYouPlayingBanjo(string name)
        {
            return name.ToLower().StartsWith("r")
                ? $"{name} plays banjo"
                : $"{name} does not play banjo";
        }

        /*
         * https://www.codewars.com/kata/563b74ddd19a3ad462000054
         * write me a function stringy that takes a size and returns a string of alternating '1s' and '0s'.
         * the string should start with a 1.
         * a string with size 6 should return :'101010'.
         * with size 4 should return : '1010'.
         * with size 12 should return : '101010101010'.
         * The size will always be positive and will only use whole numbers.
         */
        public static string Stringy(int size)
        {
            return string.Join("", Enumerable.Range(0, size).Select(x => (x + 1) % 2));
        }

        /*
         * https://www.codewars.com/kata/568dc014440f03b13900001d
         */

        public static string GetDrinkByProfession(string p)
        {
            return p.ToLower() switch
            {
                string a when a.Contains("jabroni") => "Patron Tequila",
                string a when a.Contains("school counselor") => "Anything with Alcohol",
                string a when a.Contains("programmer") => "Hipster Craft Beer",
                string a when a.Contains("gang member") => "Moonshine",
                string a when a.Contains("politician") => "Your tax dollars",
                string a when a.Contains("rapper") => "Cristal",
                _ => "Beer",
            };
        }

        /*
         * https://www.codewars.com/kata/56a946cd7bd95ccab2000055
         * Your task is simply to count the total number of lowercase letters in a string.
         */
        public static int LowercaseCountCheck(string s)
        {
            return Regex.Matches(s, "[a-z]").Count;
        }
    }
}
