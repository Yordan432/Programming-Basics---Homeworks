using System;
class Rhomb
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int spaces = n - 1;

        int stars = 1;
        for (int i = 0; i < n; i++)
        {
            Console.Write(new string(' ' , spaces));
            string starsPrint = printStars(stars);
            Console.WriteLine(starsPrint);
            stars++;
            spaces--;
        }
        spaces = 1;
        stars = n - 1;
        for (int i = 0; i < n - 1; i++)
        {
            Console.Write(new string(' ' , spaces));
            string starsPrint = printStars(stars);
            Console.WriteLine(starsPrint);

            spaces++;
            stars--;
        }
    }

    private static string printStars(int stars)
    {
        string result = "";
        for (int i = 0; i < stars; i++)
        {
            result += "* ";
        }
        return result;
    }
}

