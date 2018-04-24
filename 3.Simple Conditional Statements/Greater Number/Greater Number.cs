using System;
class GreaterNumber
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        int max = 0;
        if (firstNumber > secondNumber)
        {
            max = firstNumber;
        }
        else
        {
            max = secondNumber;
        }

        Console.WriteLine(max);
    }
}

