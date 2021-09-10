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
    }
}
