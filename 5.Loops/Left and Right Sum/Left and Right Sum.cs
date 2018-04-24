using System;
class LeftAndRightSum
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int leftSum = 0;
        for (int i = 0; i < number; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            leftSum += currentNumber;
        }

        int rightSum = 0;
        for (int i = 0; i < number; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            rightSum += currentNumber;
        }
        if (leftSum == rightSum)
        {
            Console.WriteLine("Yes , sum = {0}" , leftSum);
        }
        else
        {
            Console.WriteLine("No , diff = {0}" , Math.Abs(leftSum - rightSum));
        }
    }
}

