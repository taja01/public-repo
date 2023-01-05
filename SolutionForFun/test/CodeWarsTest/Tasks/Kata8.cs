using System;
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

        /*
         * https://www.codewars.com/kata/57b58827d2a31c57720012e8
         */
        public static double FuelPrice(double litres, double pricePerLitre)
        {
            return Math.Round((pricePerLitre - Math.Min(0.25, (int)(litres / 2) * 0.05)) * litres, 2);
        }

        //https://www.codewars.com/kata/5ad0d8356165e63c140014d4
        public static int FinalGrade(int exam, int projects)
        {
            if (exam > 90 || projects > 10)
            {
                return 100;
            }
            if (exam > 75 && projects >= 5)
            {
                return 90;
            }
            if (exam > 50 && projects >= 2)
            {
                return 75;
            }

            return 0;
        }

        //https://www.codewars.com/kata/5a6663e9fd56cb5ab800008b
        public static int[] HumanYearsCatYearsDogYears(int humanYears)
        {
            int animalCalc(int c)
            {
                var s = 15;
                for (int i = 1; i < humanYears; i++)
                {
                    if (i == 1)
                    {
                        s += 9;
                    }
                    else
                    {
                        s += c;
                    }
                }
                return s;
            }

            return new int[] { humanYears, animalCalc(4), animalCalc(5) };
        }

        //return 2nd smallest
        //Do not use linq!
        public static int? SecondSmallest(int[] arr)
        {
            if (arr == null || arr.Length <= 1)
            {
                return null;
            }


            var firstSmallest = int.MaxValue;
            var secondSmallest = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < firstSmallest)
                {
                    secondSmallest = firstSmallest;
                    firstSmallest = arr[i];
                }

                if (arr[i] > firstSmallest && arr[i] < secondSmallest)
                {
                    secondSmallest = arr[i];
                }
            }

            return secondSmallest;
        }

        //https://www.codewars.com/kata/5dd462a573ee6d0014ce715b/train/csharp
        public static int SameCase(char a, char b)
        {
            if (!char.IsLetter(a) || !char.IsLetter(b))
            {
                return -1;
            }

            return char.IsUpper(a) == char.IsUpper(b)
                ? 1
                : 0;
        }

        //https://www.codewars.com/kata/5bb0c58f484fcd170700063d
        public static int Pillars(int numPill, int dist, int width)
        {
            if (numPill < 2) return 0;

            return (numPill - 1) * dist * 100 + (numPill - 2) * width;
        }

        //https://www.codewars.com/kata/5b73fe9fb3d9776fbf00009e
        //Your task is to sum the differences between consecutive pairs in the array in descending order.
        public static int SumOfDifferences(int[] arr)
        {
            //if (arr.Length < 2) return 0;

            //var ordered = arr.OrderByDescending(x => x).Sum((x,);

            //var sum = 0;

            //for (int i = 1; i < ordered.Count(); i++)
            //{
            //    sum += ordered.ElementAt(i - 1) - ordered.ElementAt(i);
            //}

            //return sum;

            return arr.Length > 1 ? arr.Max() - arr.Min() : 0;
        }
    }
}
