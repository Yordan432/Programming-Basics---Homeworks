using System;

namespace SquareofStars
{
    class SquarofStars
    {
        static void Main()
        { 
            //НЕ РЕШЕНА ДОКРАЙ ЗАДАЧА

            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*' , n));

            for (int i = 1; i <n-2; i++)
            {
                Console.Write(new string(' ' , n-2));
                Console.Write("*");
                Console.Write(new string('*', n));
            }
            Console.WriteLine();
        }
    }
}
