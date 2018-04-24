using System;
class ConsoleIntervalConverter
{
    static void Main()
    {
        double sum = double.Parse(Console.ReadLine());
        string from = Console.ReadLine().ToLower();
        string to = Console.ReadLine().ToLower();

        double bgnCursor = 1.79549;
        double euroCursor = 1.95583;
        double gbpCursor = 2.53405;
        if (from == "usd")
        {
            switch (to)
            {
                case "bgn":
                    Console.WriteLine("{0:f2}" , sum * bgnCursor);
                    break;
                case "eur":
                    Console.WriteLine("{0:f2}" , sum * euroCursor);
                    break;
                case "gbp":
                    Console.WriteLine("{0:f2}" , sum * gbpCursor);
                    break;
            }
        }
        else if (from == "bgn")
        {
            switch (to)
            {
                case "usd":
                    Console.WriteLine("{0:f2}" , sum / bgnCursor);
                    break;
                case "eur":
                    Console.WriteLine("{0:f2}", sum / euroCursor);
                    break;
                case "gbp":
                    Console.WriteLine("{0:f2}" , sum / gbpCursor);
                    break;

            }
        }
        else if(from == "eur")
        {
            switch (to)
            {
                case "bgn":
                    Console.WriteLine("{0:f2}" , sum * 2.53405);
                    break;
                case "usd":
                    Console.WriteLine("{0:f2}" , sum * 1.08930);
                    break;
                case "gbp":
                    Console.WriteLine("{0:f2}", sum * 0.77181);
                    break;
            }
        }
        else if(from == "")
        {
            switch (to)
            {
                case "bgn":
                    Console.WriteLine("{0:f2}" , sum * 0.39462);
                    break;
                case "usd":
                    Console.WriteLine("{0:f2}" , sum * 2.53405 / 1.79549);
                    break;
                case "eur":
                    Console.WriteLine("{0:f2}" , sum * 0.77181);
                    break;
            }
        }
    }
}

