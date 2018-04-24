using System;
class Fibonacci
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int lastNumber1 = 1;
        int lastNumber2 = 1;

        int sumFibonacci = 0;

        if (number < 2)
        {
            Console.WriteLine("1");
            return;
        }
        else
        {
            int counter = 1;
            while (true)
            {
                sumFibonacci = lastNumber1 + lastNumber2;
                counter++;
                if (counter == number)
                {
                    break;
                }
                lastNumber1 = lastNumber2;
                lastNumber2 = sumFibonacci;


            }
        }
        Console.WriteLine(sumFibonacci);
    }
}

