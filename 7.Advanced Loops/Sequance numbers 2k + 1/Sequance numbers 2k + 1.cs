using System;
class SequanceNumbers2k1
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int counter = 1;
        Console.WriteLine(counter);

        while (true)
        {
            counter = counter * 2 + 1;
            if (counter > n)
            {
                break;
            }
            Console.WriteLine(counter);
        }
    }
}
