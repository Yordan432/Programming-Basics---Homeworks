using System;
class Time15Minutes
{
    static void Main()
    {
        int hour = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());

        minutes += 15;
        if (minutes > 59)
        {
            hour++;
            minutes -= 60;
        }
        if (hour > 23)
        {
            hour = 0;
        }
        if (minutes < 10)
        {
            Console.WriteLine("{0}:0{1}" , hour , minutes);
        }
        else
        {
            Console.WriteLine("{0}:{1}" , hour  , minutes);
        }
    }
}

