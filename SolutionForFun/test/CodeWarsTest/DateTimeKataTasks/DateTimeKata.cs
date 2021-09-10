using System;

namespace CodeWarsTests.DateTimeKataTasks
{
    public class DateTimeKata
    {
        /*
         * As a good developer you have to practice a lot. One way to achieve this is to finish one kata every day after work.
         * But of course you won't have time for that every day. 
         * So maybe you skip one week and think you can do two katas every day in the following week. 
         * But of course you lose track of how many katas you should have finished until today.
         * To control yourself, write a function which gets the start date of your codewars registration and returns how many katas you should have finished until today. We will ignore public holidays.
         */
        public static int SolvedKatasSince(DateTime registrationDate, DateTime currentDate)
        {
            var counter = 0;
            for (var d = registrationDate; d < currentDate; d = d.AddDays(1))
            {
                var b = d.DayOfWeek;
                if (b != DayOfWeek.Saturday && b != DayOfWeek.Sunday)
                {
                    counter++;
                }
            }
            return counter;
        }

        /*
         * The Chinese zodiac is a repeating cycle of 12 years, with each year being represented by an animal and its reputed attributes. 
         * The lunar calendar is divided into cycles of 60 years each, and each year has a combination of an animal and an element. 
         * There are 12 animals and 5 elements; the animals change each year, and the elements change every 2 years. The current cycle was initiated in the year of 1984 which was the year of the Wood Rat.
         * Since the current calendar is Gregorian, I will only be using years from the epoch 1924. For simplicity I am counting the year as a whole year and not from January/February to the end of the year.
         * #Task
         * Given a year, return the element and animal that year represents ("Element Animal"). For example I'm born in 1998 so I'm an "Earth Tiger".
         * 
         * animals (or $animals in Ruby) is a preloaded array containing the animals in order:
         * ['Rat', 'Ox', 'Tiger', 'Rabbit', 'Dragon', 'Snake', 'Horse', 'Goat', 'Monkey', 'Rooster', 'Dog', 'Pig']
         * 
         * elements (or $elements in Ruby) is a preloaded array containing the elements in order:
         * ['Wood', 'Fire', 'Earth', 'Metal', 'Water']
         */
        public static string ChineseZodiac(int year)
        {
            var animals = new[] { "Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Goat", "Monkey", "Rooster", "Dog", "Pig" };
            var elements = new[] { "Wood", "Fire", "Earth", "Metal", "Water" };

            return $"{elements[((year / 2) - 2) % 5]} {animals[(year - 1924) % 12]}";
        }
    }
}
