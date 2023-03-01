using System;

namespace CodeWarsTests.Tasks._202303 {
    internal class Practise202303 {

        //https://www.codewars.com/kata/58d248c7012397a81800005c/train/csharp
        public static bool IsCube(double volume, double side) {
            //if (volume < 1 || side < 1) return false;

            //return side * side * side == volume;

            return Math.Pow(side, 3) == volume && volume > 0 && side > 0;
        }
    }
}
