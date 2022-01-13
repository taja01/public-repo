using System.Linq;
namespace CodeWarsTests.StringTasks
{
    public static class StringExtensionKataTask01
    {
        /*
         * * https://www.codewars.com/kata/5c81aaf99043851c65ce7f5b
        * Your task is to write an extension method for the String class called Score(), that returns an integer score for any given string.
        * The score is calculated thus:
        * Each letter is given a numeric value, where A = 1, B = 2, up through Z = 26 (non-case-sensitive). 
        * The score is the sum of all values.
        * Ignore any non-alpha characters in the string. 
        * If there are no alpha characters in the string, the score is 0.
        */
        public static int Score(this string s)
        {
            return s.ToLower()
                    .Where(c => char.IsLetter(c))
                    .Sum(x => x - 96);
        }

    }
}
