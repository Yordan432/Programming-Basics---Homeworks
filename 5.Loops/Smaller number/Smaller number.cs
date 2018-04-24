using System;
class SmallerNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int min = int.MaxValue;

        for (int i = 0; i < number; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());

            min = Math.Min(currentNumber, min);
        }
        Console.WriteLine(min);
    }
}

