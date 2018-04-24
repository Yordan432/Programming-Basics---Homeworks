using System;
class ExcellentOrNot
{
    static void Main()
    {
        double evaluation = double.Parse(Console.ReadLine());

        if (evaluation >=5.50)
        {
            Console.WriteLine("Excellent!");
        }
        else
        {
            Console.WriteLine("Not excellent.");
        }
    }
}

