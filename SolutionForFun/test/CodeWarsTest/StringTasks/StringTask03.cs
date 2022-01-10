using System.Linq;

namespace CodeWarsTests.StringTasks
{
    public partial class Kata
    {
        /*
         * https://www.codewars.com/kata/57eae65a4321032ce000002d
         * Given a string of digits, you should replace any digit below 5 with '0' and any digit 5 and above with '1'.
         * Return the resulting string.
         * Note: input will never be an empty string
         */
        public static string FakeBin(string x)
        {
            return string.Concat(x.Select(i => i < '5' ? "0" : "1")).ToUpper();
        }

        /*
         * https://www.codewars.com/kata/5556282156230d0e5e000089
         * Deoxyribonucleic acid, DNA is the primary information storage molecule in biological systems. 
         * It is composed of four nucleic acid bases Guanine ('G'), Cytosine ('C'), Adenine ('A'), and Thymine ('T').
         * Ribonucleic acid, RNA, is the primary messenger molecule in cells. 
         * RNA differs slightly from DNA its chemical structure and contains no Thymine. 
         * In RNA Thymine is replaced by another nucleic acid Uracil ('U').
         * Create a function which translates a given DNA string into RNA.
         * For example:
         * "GCAT"  =>  "GCAU"
         */
        public static string DnaToRna(string dna)
        {
            return dna.Replace("T", "U");
        }

        /*
         * https://www.codewars.com/kata/57eadb7ecd143f4c9c0000a3
         * Write a function to convert a name into initials.
         * This kata strictly takes two words with one space in between them.
         * The output should be two capital letters with a dot separating them.
         * It should look like this:
         * Sam Harris => S.H
         * patrick feeney => P.F
         */
        public static string AbbrevName(string name)
        {
            return string.Join(".", name.Split(" ").Select(x => x[0]));
        }

        /*
         * https://www.codewars.com/kata/57e76bc428d6fbc2d500036d
         * Write a function to split a string and convert it into an array of words. For example:
         * "Robin Singh" ==> ["Robin", "Singh"]
         * "I love arrays they are my favorite" ==> ["I", "love", "arrays", "they", "are", "my", "favorite"]
         */
        public static string[] StringToArray(string str)
        {
            return str.Split(' ');
        }

        /*
         * https://www.codewars.com/kata/57cff961eca260b71900008f
         * Given an array of numbers, check if any of the numbers are the character codes for lower case vowels (a, e, i, o, u).
         * If they are, change the array value to a string of that vowel.
         * Return the resulting array.
         */
        public static object[] IsVow(object[] a)
        {
            object[] vowels = new object[] { 97, 101, 105, 117, 111 };

            return a.Select(x => vowels.Contains(x) ? char.ConvertFromUtf32((int)x) : x).ToArray();
        }
    }
}
