﻿using System;

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
    }
}
