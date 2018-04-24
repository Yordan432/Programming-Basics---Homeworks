using System;
class ChristmasSock
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int count = n + n;
        Console.Write("|");
        Console.Write(new string('-' , count));
        Console.WriteLine("|");

        Console.Write("|");
        Console.Write(new string('*' , count));
        Console.WriteLine("|");
        
        Console.Write("|");
        Console.Write(new string('-', count));
        Console.WriteLine("|");

        // 6 * 3 / 2
        int mid = n - 1;
        int tire = n - 1;
        int tilda = 2;
        for (int i = 0; i < mid; i++)
        {
            Console.Write("|");
            Console.Write(new string('-' , tire));
            Console.Write(new string('~' , tilda));
            Console.Write(new string('-', tire));
            Console.WriteLine("|");
            tilda += 2;
            tire--;
        }
        int midLast = n - 2;
       
        //if (n % 2 == 0)
        //{
        //    tilda = tilda - 4;
        //}
        //else5
        //{
        //    tilda = 2;
        //}

      //  tire = 2;
       // tilda = (int)Math.Ceiling(n / 2.0);
        for (int i = 0; i < midLast; i++)
        {
            Console.Write("|");
            Console.Write(new string('-' , tire));
            Console.Write(new string('~' , tilda));
            Console.Write(new string('-', tire));
            Console.WriteLine("|");
            tire+=2;
            tilda -= 2;
        }
        int points = n + n + 1;
        Console.Write("\\");
        Console.Write(new string('.', points));
        Console.WriteLine("\\");

        tire = 1;
        count = n - 4;
        for (int i = 0; i < count; i++)
        {
            Console.Write(new string('-' , tire));
            Console.Write("\\");
            Console.Write(new string('.' , points));
            Console.WriteLine("\\");

            tire++;
        }
        tire = n / 2;

        Console.Write(new string('-' , tire));
        Console.Write("\\");
        Console.Write(new string('.' , n - 2));
        Console.Write("MERRY");
        Console.Write(new string('.', n - 2));
        Console.WriteLine("\\");

        tire++;
        Console.Write(new string('-', tire));
        Console.Write("\\");
        Console.Write(new string('.' , points));
        Console.WriteLine("\\");

        tire++;
        Console.Write(new string('-' , tire));
        Console.Write("\\");
        Console.Write(new string('.' , n - 2));
        Console.Write("X-MAS");
        Console.Write(new string('.', n - 2));
        Console.WriteLine("\\");

        tire++;
        for (int i = 0; i < n / n; i++)
        {
            Console.Write(new string('-' , tire));
            Console.Write("\\");
            Console.Write(new string('.' , points));
            Console.WriteLine("\\");
        }
        tire++;
        Console.Write(new string('-' , tire));
        Console.Write("\\");
        Console.Write(new string('_', n + n + 1));
        Console.WriteLine(")");
    }
}

