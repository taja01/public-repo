using System.Linq;

namespace CodeWarsTests.Tasks
{
    public partial class Kata
    {
        //https://www.codewars.com/kata/57a2013acf1fa5bfc4000921
        //Write a function which calculates the average of the numbers in a given list.
        // Should return 0 on empty array
        public static double FindAverage(double[] array)
        {
            return array.Length > 0
                ? array.Average()
                : 0;
        }

        /*
         * https://www.codewars.com/kata/557cd6882bfa3c8a9f0000c1
         * Assume test input string always valid and may look like "1 year old" or "5 years old", etc.. The first char is number only.
         */
        public static int GetAge(string inputString)
        {
            return (int)char.GetNumericValue(inputString[0]);
        }
    }
}
