using System;
class Sunglasses
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
       
        int stars = n * 2;
        int spaces = n;
        Console.Write(new string('*' , stars));
        Console.Write(new string(' ' , spaces));
        Console.WriteLine(new string('*', stars));
        
        int row = 1;
        // 4 - 1 / 2 - 1
        for (int i = 0; i <n - 2; i++)
        {
            Console.Write("*");
            double expression = Math.Ceiling(n * 3.0 / 2);
            Console.Write(new string('/' , 2 * n - 2));
            Console.Write("*");

            if (i == (n - 1) / 2 - 1)
            {
                Console.Write(new string('|', n));
            }
            else
            {
                Console.Write(new string(' ' , n));
            }
            Console.Write("*");
            Console.Write(new string('/', 2 * n - 2));
            Console.WriteLine("*");
            row++;
            

        }
        Console.Write(new string('*', stars));
        Console.Write(new string(' ', spaces));
        Console.WriteLine(new string('*', stars));
    }
}
