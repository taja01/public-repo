using System.Linq;

namespace CodeWarsTests.StringTasks
{
    public partial class Kata
    {
        /*
         * https://www.codewars.com/kata/5aa736a455f906981800360d
         * All of the animals are having a feast! Each animal is bringing one dish. 
         * There is just one rule: the dish must start and end with the same letters as the animal's name. 
         * For example, the great blue heron is bringing garlic naan and the chickadee is bringing chocolate cake.
         * Write a function feast that takes the animal's name and dish as arguments and returns true or false to indicate whether the beast is allowed to bring the dish to the feast.
         * Assume that beast and dish are always lowercase strings, and that each has at least two letters. beast and dish may contain hyphens and spaces, but these will not appear at the beginning or end of the string. They will not contain numerals.
         */
        public static bool Feast(string beast, string dish)
        {
            return beast[0] == dish[0] && beast[beast.Length - 1] == dish[dish.Length - 1];
        }

        /*
         * https://www.codewars.com/kata/5a360620f28b82a711000047
         * You get any card as an argument. Your task is to return a suit of this card.
        string[] Deck =
        {
            "2♣", "3♣", "4♣", "5♣", "6♣", "7♣", "8♣", "9♣", "10♣", "J♣", "Q♣", "K♣", "A♣",
            "2♦", "3♦", "4♦", "5♦", "6♦", "7♦", "8♦", "9♦", "10♦", "J♦", "Q♦", "K♦", "A♦",
            "2♥", "3♥", "4♥", "5♥", "6♥", "7♥", "8♥", "9♥", "10♥", "J♥", "Q♥", "K♥", "A♥",
            "2♠", "3♠", "4♠", "5♠", "6♠", "7♠", "8♠", "9♠", "10♠", "J♠", "Q♠", "K♠", "A♠"
        };
         */
        public static string DefineSuit(string card)
        {
            return card[^1] switch
            {
                '♣' => "clubs",
                '♠' => "spades",
                '♦' => "diamonds",
                _ => "hearts"
            };
        }

        /*
         * https://www.codewars.com/kata/5a2fd38b55519ed98f0000ce
         * Your goal is to return multiplication table for number that is always an integer from 1 to 10.
         * For example, a multiplication table (string) for number == 5 looks like below:
         */

        public static string MultiTable(int number)
        {
            //var list = new List<string>();
            //for (int i = 1; i <= 10; i++)
            //{
            //    list.Add($"{i} * {number} = {i * number}");
            //}
            //return string.Join("\n", list);

            return string.Join("\n", Enumerable.Range(1, 10).Select(x => $"{x} * {number} = {x * number}"));
        }

        /*
         * https://www.codewars.com/kata/53dc23c68a0c93699800041d
         * Write a function that takes an array of words and smashes them together into a sentence and returns the sentence. 
         * You can ignore any need to sanitize words or add punctuation, but you should add spaces between each word. 
         * Be careful, there shouldn't be a space at the beginning or the end of the sentence!
         */
        public static string Smash(string[] words)
        {
            return string.Join(" ", words);
        }
    }
}
