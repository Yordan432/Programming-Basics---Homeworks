using System;
class ChristmasTree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int space = n + 1;

        Console.Write(new string(' ', space));
        Console.WriteLine("|");

        space = n - 1;
        int stars = 1;

        for (int i = 0; i < n; i++)
        {
            Console.Write(new string(' ' , space));
            Console.Write(new string('*' , stars));
            Console.Write(" ");
            Console.Write("|");
            Console.Write(" ");
            Console.WriteLine(new string('*', stars));

            space--;
            stars++;

        }
    }
}
