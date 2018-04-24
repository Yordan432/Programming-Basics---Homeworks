using System;
class TheLargestCommonDivisor
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        while (true)
        {
            if (a % b == 0)
            {
                break;
            }
            int remainder = a % b;
            a = b;
            b = remainder;
        }
        Console.WriteLine(b);
    }
}

