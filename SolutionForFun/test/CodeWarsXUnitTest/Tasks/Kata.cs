using System.Linq;

namespace CodeWarsXUnitTest.Tasks
{
    public static class Kata
    {
        /*
         * Trolls are attacking your comment section!
         * A common way to deal with this situation is to remove all of the vowels from the trolls' comments, neutralizing the threat.
         * Your task is to write a function that takes a string and return a new string with all vowels removed.
         * For example, the string "This website is for losers LOL!" would become "Ths wbst s fr lsrs LL!".
         * Note: for this kata y isn't considered a vowel.
         */
        public static string Disemvowel(string str)
        {
            return new string(str.Where(c => !"aeiuoAEIOU".Contains(c)).ToArray());
        }

        /*
         * Bob is preparing to pass IQ test. The most frequent task in this test is to find out which one of the given numbers differs from the others.
         * Bob observed that one number usually differs from the others in evenness.
         * Help Bob — to check his answers, he needs a program that among the given numbers finds one that is different in evenness, and return a position of this number.
         * ! Keep in mind that your task is to help Bob solve a real IQ test, which means indexes of the elements start from 1 (not 0)
         */
        public static bool XO(string input)
        {
            var xCount = input.ToLower().Count(c => c == 'x');
            var oCount = input.ToLower().Count(c => c == 'o');

            return xCount == oCount;
        }

        public static int PositiveSum(int[] arr)
        {
            return arr.Where(x => x > 0).Sum();
        }

        //Write a function called repeatString which repeats the given String src exactly count times.
        public static string RepeatStr(int n, string s)
        {
            return string.Concat(Enumerable.Repeat(s, n));
        }
    }
}
