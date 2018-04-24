using System;
class APyramidOfNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int counter = 1;
        for (int row = 1; row <=number; row++)
        {
            for (int col = 1; col <=row; col++)
            {
                if (counter - 1 == number)
                {
                    break;
                }
                Console.Write(counter + " ");
                counter++;
            }
            if (counter - 1 == number)
            {
                break;
            }
             
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
