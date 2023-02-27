using System;
using System.Linq;

namespace CodeWarsTests.StringTasks {
    public partial class Kata {
        /*
         * https://www.codewars.com/kata/5a262cfb8f27f217f700000b
         * In this Kata, you will be given two strings a and b and your task will be to return the characters that are not common in the two strings.
         */
        public static string Solve(string a, string b) {
            return string.Concat(string.Concat(a.Where(x => !b.Contains(x)))) + string.Concat(string.Concat(b.Where(x => !a.Contains(x))));
        }

        /*
         * https://www.codewars.com/kata/5a1e6323ffe75f71ae000026
         */
        public static bool IsTuringEquation(string str) {
            //var a = new string(str.Reverse().ToArray()).Split('+', '=').Select(x => int.Parse(x)).ToArray();

            //return a[0] == a[1] + a[2];

            return ("-" + string.Concat(str.Reverse())).Split('+', '=').Select(x => int.Parse(x)).Sum() == 0;
        }

        /*
         * https://www.codewars.com/kata/5a145ab08ba9148dd6000094
         * In this Kata, you will write a function doubles that will remove double string characters that are adjacent to each other.
         */
        public static string Doubles(string str) {
            for (int i = 0; i < str.Length - 1; i++) {
                if (str[i] == str[i + 1]) {
                    str = str.Remove(i, 2);
                    i = -1;
                }
            }

            return str;
        }

        //https://www.codewars.com/kata/595970246c9b8fa0a8000086
        /* Your coworker was supposed to write a simple helper function to capitalize a string (that contains a single word) before they went on vacation.
         * Unfortunately, they have now left and the code they gave you doesn't work. Fix the helper function they wrote so that it works as intended (i.e. make the first character in the string "word" upper case).
         * Don't worry about numbers, special characters, or non-string types being passed to the function. The string lengths will be from 1 character up to 10 characters, but will never be empty.
         */
        public static string CapitalizeWord(string word) {
            //var a = word.ToCharArray();
            //a[0] = char.ToUpper(a[0]);
            //return new string(a);

            return char.ToUpper(word[0]) + word.Substring(1);
        }

        //https://www.codewars.com/kata/546f922b54af40e1e90001da/train/csharp
        /*
         * In this kata you are required to, given a string, replace every letter with its position in the alphabet.
         * If anything in the text isn't a letter, ignore it and don't return it.
         * "a" = 1, "b" = 2, etc.
         * Example
         * Kata.AlphabetPosition("The sunset sets at twelve o' clock.")
         */

        public static string AlphabetPosition(string text) {
            return string.Join(" ", text.ToLower().Where(c => char.IsLetter(c)).Select(x => (int)x - 96));

            //other solutions:
            //return string.Join(" ", text.ToLower().Where(char.IsLetter).Select(x => x - 'a' + 1));

            //return string.Join(" ", text.Where(char.IsLetter).Select(c => c & 31));
        }
    }
}