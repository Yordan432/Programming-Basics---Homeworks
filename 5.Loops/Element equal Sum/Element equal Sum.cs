using System;
using System.Collections.Generic;

class ElementEqualSum
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int max = 0;
        int sum = 0;
        for (int i = 0; i < number; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            if (currentNumber > max)
            {
                max = currentNumber;
            }
            sum += currentNumber;
        }
        sum = sum - max;
        if (sum == max)
        {
            Console.WriteLine("Yes\nSum = {0}" , sum);
        }
        else
        {
            Console.WriteLine("No\nDiff = {0}" , Math.Abs(sum - max));
        }
    }
}

