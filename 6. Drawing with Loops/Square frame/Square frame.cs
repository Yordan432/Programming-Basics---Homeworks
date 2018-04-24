using System;
class SquareFrame
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.Write("+ ");
        string tire = printTire(n);
        Console.Write(tire);
        Console.Write("+");
        Console.WriteLine();

        for (int i = 0; i < n - 2; i++)
        {
            Console.Write("| ");
            tire = printTire(n);
            Console.Write(tire);
            Console.WriteLine("|");
        }

        Console.Write("+ ");
        Console.Write(tire);
        Console.Write("+");
        Console.WriteLine();
    }

    private static string printTire(int n)
    {
        string result = "";
        for (int i = 0; i < n - 2; i++)
        {
            result += "- ";
        }
        return result;
    }
}

