using System;
using System.Collections.Generic;

class EvenOddPosition
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        double oddSum = 0;
        double oddMin = int.MaxValue;
        double oddMax = int.MinValue;

        double evenSum = 0;
        double evenMin = int.MaxValue;
        double evenMax = int.MinValue;

        int row = 1;
        for (int i = 0; i < n; i++)
        {
            double currentNumber = double.Parse(Console.ReadLine());
            if (row % 2 == 1)
            {
                oddSum += currentNumber;
                if (oddMin > currentNumber)
                {
                    oddMin = currentNumber;
                }
                if (oddMax < currentNumber)
                {
                    oddMax = currentNumber;
                }
            }
            else
            {
                evenSum += currentNumber;
                if (evenMin > currentNumber)
                {
                    evenMin = currentNumber;
                }
                if (evenMax < currentNumber)
                {
                    evenMax = currentNumber;
                }
            }
            row++;
        }
        string oddMinAsString = oddMin.ToString();
        string oddMaxAsString = oddMax.ToString();

        Console.WriteLine("OddSum={0},",oddSum);
        Console.WriteLine("OddMin={0}," , oddMin != int.MaxValue ? oddMinAsString : "no");
        Console.WriteLine("OddMax={0}," , oddMax != int.MinValue ? oddMaxAsString : "no");

        string evenMinAsString = evenMin.ToString();
        string evenMaxAsString = evenMax.ToString();
        Console.WriteLine("EvenSum={0}," , evenSum);
        Console.WriteLine("EvenMin={0}," ,evenMin != int.MaxValue ? evenMinAsString : "no");
        Console.WriteLine("EvenMax={0}" , evenMax != int.MinValue ? evenMaxAsString : "no");
    }
}

