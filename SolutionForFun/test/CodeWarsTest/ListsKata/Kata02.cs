using System.Collections.Generic;
using System.Linq;

namespace CodeWarsTests.ListsKata
{
    partial class Kata
    {
        //https://www.codewars.com/kata/53dbd5315a3c69eed20002dd
        //In this kata you will create a function that takes a list of non-negative integers and strings and
        //returns a new list with the strings filtered out.
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            //return listOfItems
            //    .Where(x => x.GetType() == Type.GetType("System.Int32"))
            //    .Select(y => int.Parse(y.ToString()));

            return listOfItems.OfType<int>();
        }
    }
}
