using System;
class Volleyball
{
    static void Main()
    {
        string year = Console.ReadLine();
        int countHolidaysYear = int.Parse(Console.ReadLine());
        int countWeekends = int.Parse(Console.ReadLine());

        int totalCountWeekends = 48;
        int countWeekendsInSofia = totalCountWeekends - countWeekends;

        int countWeekendsInHerCity = totalCountWeekends - countWeekendsInSofia;

        double gameInSofia = (double)countWeekendsInSofia * 3 / 4;


        double holidays = (double)countHolidaysYear * 2 / 3;

        double totalGameHolidays = gameInSofia + countWeekendsInHerCity + holidays;

        if (year == "leap")
        {
            double furtherGame = 0.15 * totalGameHolidays;

            double totalFullYear = totalGameHolidays + furtherGame;
            Console.WriteLine((int)totalFullYear);
        }
        else
        {
            Console.WriteLine((int)totalGameHolidays);
        }
    }
}

