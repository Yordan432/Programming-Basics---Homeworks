using System;
class SumSeconds
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());

        int totalSum = first + second + third;
        int min = totalSum / 60;

       int minutes = totalSum % 60;

        Console.WriteLine("{0}:{1}", min, minutes.ToString().PadLeft(2, '0'));
    }
}

