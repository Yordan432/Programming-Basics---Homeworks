using System;
class NumberInRange
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        while (true)
        {
            if (number > 0 && number <= 100)
            {
                Console.WriteLine("The number is: {0}" , number);
                break;
            }
            Console.WriteLine("Invalid number!");
            number = int.Parse(Console.ReadLine());
        }
    }
}

