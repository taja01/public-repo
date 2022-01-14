using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWarsTests.StringTasks
{
    public partial class Kata
    {
        /*
        * https://www.codewars.com/kata/5b5e0c0d83d64866bc00001d
        * You have a string of numbers; starting with the third number each number is the result of an operation performed using the previous two numbers.
        * Complete the function which returns a string of the operations in order and separated by a comma and a space, e.g. "subtraction, subtraction, addition"
        */
        public static string SayMeOperations(string stringNumbers)
        {
            var arr = stringNumbers.Split(' ').Select(x => int.Parse(x)).ToList();
            //var operation = new List<string>();

            //for (int i = 1; i < arr.Count() - 1; i++)
            //{
            //    if (arr[i - 1] + arr[i] == arr[i + 1])
            //    {
            //        operation.Add("addition");
            //    }
            //    else if (arr[i - 1] * arr[i] == arr[i + 1])
            //    {
            //        operation.Add("multiplication");
            //    }
            //    else if (arr[i - 1] - arr[i] == arr[i + 1])
            //    {
            //        operation.Add("subtraction");
            //    }
            //    else
            //    {
            //        operation.Add("division");
            //    }
            //}

            //return string.Join(", ", operation);

            return string.Join(", ", Enumerable.Range(0, arr.Count() - 2).Select(i =>
                        arr[i] + arr[i + 1] == arr[i + 2] ? "addition" :
                        arr[i] - arr[i + 1] == arr[i + 2] ? "subtraction" :
                        arr[i] * arr[i + 1] == arr[i + 2] ? "multiplication" : "division"));
        }

        /*
         * https://www.codewars.com/kata/5b39e3772ae7545f650000fc
         * Your task is to remove all duplicate words from a string, leaving only single (first) words entries.
         * Example:
         * Input:
         * 'alpha beta beta gamma gamma gamma delta alpha beta beta gamma gamma gamma delta'
         * Output:
         * 'alpha beta gamma delta'
         */
        public static string RemoveDuplicateWords(string s)
        {
            return string.Join(' ', s.Split(' ').Distinct());
        }

        /*
         * https://www.codewars.com/kata/5b37a50642b27ebf2e000010
         * Beaches are filled with sand, water, fish, and sun.
         * Given a string, calculate how many times the words "Sand", "Water", "Fish", and "Sun" appear without overlapping (regardless of the case).
         */
        public static int SumOfABeach(string s)
        {
            return Regex.Matches(s, "(sand|fish|water|sun)", RegexOptions.IgnoreCase).Count;
        }

    }
}
