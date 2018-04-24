using System;
class EvenNumber
{
    static void Main()
    {
        string input = Console.ReadLine();

        double num = 0.0;
        while (true)
        {
            bool isNumber = double.TryParse(input, out num);
            if (isNumber)
            {
                if (num % 2 == 0)
                {
                    break; 
                }
                Console.WriteLine("The number is not even.");
                Console.Write("Enter even number: ");
                input = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid number!");
                input = Console.ReadLine();
            }
        }
        Console.WriteLine("Even number entered: {0}" , num);
    }
}
