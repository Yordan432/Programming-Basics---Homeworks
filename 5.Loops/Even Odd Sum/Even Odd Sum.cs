using System;
class EvenOddSum
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int evenSum = 0;
        int oddSum = 0;
        int row = 1;
        for (int i = 0; i < number; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            if (row % 2 == 1)
            {
                oddSum += currentNumber;
            }
            else
            {
                evenSum += currentNumber;
            }
            row++;
        }
        if (evenSum == oddSum)
        {
            Console.WriteLine("Yes, Sum = {0}" , evenSum);
        }
        else
        {
            Console.WriteLine("No , Diff = {0}" , Math.Abs(evenSum - oddSum));
        }
    }
}

