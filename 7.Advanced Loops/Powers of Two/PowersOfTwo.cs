using System;
class PowersOfTwo
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
        while (counter <= powerNumber)
        {
            Console.WriteLine(count);
            count *= 2;
            counter = count;
        }
    }
}
