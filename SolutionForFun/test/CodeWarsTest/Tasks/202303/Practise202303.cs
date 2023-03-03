using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWarsTests.Tasks._202303 {
    internal class Practise202303 {

        //https://www.codewars.com/kata/58d248c7012397a81800005c/train/csharp
        public static bool IsCube(double volume, double side) {
            //if (volume < 1 || side < 1) return false;

            //return side * side * side == volume;

            return Math.Pow(side, 3) == volume && volume > 0 && side > 0;
        }

        //https://www.codewars.com/kata/5ab6538b379d20ad880000ab/train/csharp
        /*
         * You are given the length and width of a 4-sided polygon. The polygon can either be a rectangle or a square.
         * If it is a square, return its area. If it is a rectangle, return its perimeter.
         */
        public static int AreaOrPerimeter(int l, int w) {
            return l == w ? l * w : 2 * (l + w);
        }

        //https://www.codewars.com/kata/5a34b80155519e1a00000009
        /*
         * Return a new array consisting of elements which are multiple of their own index in input array (length > 1).
         * [22, -6, 32, 82, 9, 25] =>  [-6, 32, 25]
         * [68, -1, 1, -7, 10, 10] => [-1, 10]
         * [-56,-85,72,-26,-14,76,-27,72,35,-21,-67,87,0,21,59,27,-92,68] => [-85, 72, 0, 68]
         */
        public static List<int> MultipleOfIndex(List<int> xs) {
            return xs.Skip(1).Where((x, i) => x % (i + 1) == 0).ToList();
        }
    }
}
