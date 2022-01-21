using System.Linq;
namespace CodeWarsTests.StringTasks
{
    public partial class Kata
    {
        /*
         * https://www.codewars.com/kata/5a262cfb8f27f217f700000b
         * In this Kata, you will be given two strings a and b and your task will be to return the characters that are not common in the two strings.
         */
        public static string Solve(string a, string b)
        {
            return string.Concat(string.Concat(a.Where(x => !b.Contains(x)))) + string.Concat(string.Concat(b.Where(x => !a.Contains(x))));
        }
    }
}
