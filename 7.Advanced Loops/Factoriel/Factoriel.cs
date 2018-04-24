using System;
class Factoriel
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());

        long factoriel = 1;
        long num = number;

        for (int i = 0; i < num; i++)
        {
            factoriel *= number;
            number--;
        }
        Console.WriteLine(factoriel);
    }
}

