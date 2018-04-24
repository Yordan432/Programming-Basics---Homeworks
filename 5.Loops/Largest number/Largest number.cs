using System;
class LargestNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        long max = long.MinValue;
      
        for (int i = 0; i < number; i++)
        {
            long currentNumber = int.Parse(Console.ReadLine());
            if (max < currentNumber)
            {
                max = currentNumber;
            }
        }
        Console.WriteLine(max);
    }
}

