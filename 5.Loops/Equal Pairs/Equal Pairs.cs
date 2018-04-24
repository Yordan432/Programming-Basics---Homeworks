using System;
using System.Collections.Generic;
using System.Linq;

class EqualPairs
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] arrNumbers = new int[n];
        int sum = 0;
        int step = 0;
        int index = 0;
        for (int i = 0; i <2 * n; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            sum += currentNumber;
            step++;
            if (step == 2)
            {
                arrNumbers[index] = sum;
                sum = 0;
                step = 0;
                index++;
            }
        }

        var distinct = arrNumbers.Distinct().ToList();
        if (distinct.Count == 1)
        {
            Console.WriteLine("Yes, value = {0}" , distinct[0]);
        }
        else
        {
            // TODO: find diff

            int diff = findDiff(distinct);
        }
    }
    private static int findDiff(List<int> distinct)
    {
        double diff = 0;

        for (int i = 0; i < distinct.Count - 1; i++)
        {
            int firstNumber = distinct[i];
            int lastNumber = distinct[i + 1];
            diff = Math.Abs(firstNumber-lastNumber);
        }

        return 0;
    }

    public static int SmallestDifference(List<int> list)
    {
        var min = int.MaxValue;

        for (int k = 0; k < list.Count - 1; k++)
        {
            min = Math.Min(min, list[k + 1] - list[k]);
        }
        return min;
    }
}

