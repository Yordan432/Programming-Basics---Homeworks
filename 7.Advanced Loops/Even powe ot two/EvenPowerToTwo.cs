using System;
class EvenPowerToTwo
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int count = 1;

        int powerNumber = 1;

        for (int i = 0; i < n; i++)
        {
            powerNumber *= 2;
        }
        int counter = 1;
        Console.WriteLine(count);
        while (counter <= powerNumber)
        {
            if (count % 2 == 0)
            {
                Console.WriteLine(count);
            }
            count *= 4;
            counter = count;
        }
    }
}

