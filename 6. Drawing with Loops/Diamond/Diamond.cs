using System;
class Diamond
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n == 1)
        {
            Console.WriteLine("*");
            return;
        }
        int countTire = (n - 1) / 2;
        Console.Write(new string('-', countTire));
        int evenStars = 2;
        int oddStars = 1;
        if (n % 2 == 0)
        {
            Console.Write(new string('*', evenStars));
        }
        else
        {
            Console.Write(new string('*', oddStars));
        }
        Console.WriteLine(new string('-', countTire));

        int leftRight = countTire - 1;

        int mid = n - 2 * leftRight - 2;
        double midCount = Math.Ceiling((n - 2) / 2.0);
        for (int i = 0; i < midCount; i++)
        {
            Console.Write(new string('-', leftRight));
            Console.Write("*");
            Console.Write(new string('-', mid));
            Console.Write("*");
            Console.WriteLine(new string('-', leftRight));
            leftRight--;
            mid += 2;
        }
        mid = n - 2 * leftRight - 6;
        int countDown = (n - 2) / 2;
        for (int i = 1; i <= countDown; i++)
        {
            Console.Write(new string('-', i));
            Console.Write("*");
            Console.Write(new string('-', mid));
            Console.Write("*");
            Console.WriteLine(new string('-', i));
            mid -= 2;
        }

        if (n % 2 == 1)
        {
            Console.Write(new string('-', countTire));
            Console.Write(new string('*', oddStars));
            Console.WriteLine(new string('-', countTire));
        }

    }
}

