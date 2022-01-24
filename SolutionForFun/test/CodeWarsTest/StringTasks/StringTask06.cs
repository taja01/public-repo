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

        /*
         * https://www.codewars.com/kata/5a1e6323ffe75f71ae000026
         */
        public static bool IsTuringEquation(string str)
        {
            //var a = new string(str.Reverse().ToArray()).Split('+', '=').Select(x => int.Parse(x)).ToArray();

            //return a[0] == a[1] + a[2];

            return ("-" + string.Concat(str.Reverse())).Split('+', '=').Select(x => int.Parse(x)).Sum() == 0;
        }

        /*
         * https://www.codewars.com/kata/5a145ab08ba9148dd6000094
         * In this Kata, you will write a function doubles that will remove double string characters that are adjacent to each other.
         */
        public static string Doubles(string str)
        {
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == str[i + 1])
                {
                    str = str.Remove(i, 2);
                    i--;
                }
            }

            return str;
        }
    }
}