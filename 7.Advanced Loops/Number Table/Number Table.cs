using System;
class NumberTable
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        for (int row = 1; row <=number; row++)
        {
            for (int col = row; col <=number; col++)
            {
                Console.Write("{0} " , col);
            }
            for (int col = number - 1; col > number - row; col--)
            {
                Console.Write("{0} " , col);
            }
            Console.WriteLine();
        }
    }
}

