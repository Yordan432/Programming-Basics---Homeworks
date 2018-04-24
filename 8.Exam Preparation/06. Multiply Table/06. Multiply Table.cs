using System;
class MultiplyTable
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int num = number;
        int lastDigit = num % 10;
        num /= 10;
        int lastTimeDigit = num % 10;
        num /= 10;
        int firstDigit = num;

        for (int i1 = 1; i1 <=lastDigit; i1++)
        {
            for (int i2 = 1; i2 <=lastTimeDigit; i2++)
            {
                for (int i3 = 1; i3 <=firstDigit; i3++)
                {
                    int multiply = i1 * i2 * i3;
                    Console.WriteLine("{0} * {1} * {2} = {3};" , i1 , i2 , i3 , multiply);
                }
            }
        }

    }
}
