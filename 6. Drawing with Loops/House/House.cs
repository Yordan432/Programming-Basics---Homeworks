using System;
class House
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        double tire = (Math.Ceiling(n / 2.0));

        int countStars = n % 2 == 0 ? 2 : 1;
        for (int i = 0; i < (n + 1) / 2; i++)
        {
            Console.Write(new string('-', (int)tire - 1));
            Console.Write(new string('*', countStars));
            Console.WriteLine(new string('-', (int)tire - 1));
            countStars += 2;
            tire--;
        }

        int asterisk = n - 2;
        for (int i = 0; i < n / 2; i++)
        {
            Console.Write("|");
            Console.Write(new string('*', asterisk));
            Console.WriteLine("|");
        }
    }
}

