using System;
class Cinema
{
    static void Main()
    {
        string projection = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        if (projection == "Premiere")
        {
            Console.WriteLine("{0:f2} leva" , rows * cols * 12.00);
        }
        else if(projection == "Normal")
        {
            Console.WriteLine("{0:f2} leva", rows * cols * 7.50);
        }
        else
        {
            Console.WriteLine("{0:f2} leva" , rows * cols * 5.00);
        }
    }
}

