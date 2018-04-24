using System;
class USD_to_BGN
{
    static void Main()
    {
        double usd = double.Parse(Console.ReadLine());

        double bgn = usd * 1.79549;

        Console.WriteLine("{0:f2} BGN" ,bgn);
    }
}
