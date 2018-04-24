using System;
class FacesOfFigures
{
    static void Main()
    {
        string figures = Console.ReadLine().ToLower();

        if (figures == "square")
        {
            int number = int.Parse(Console.ReadLine());
            int square = number * number;

            Console.WriteLine(square);
        }
        else if (figures == "rectangle")
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine(num1 * num2);
        }
        else if (figures == "circle")
        {
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("{0:f3}" , Math.PI * r * r);
        }
        else if(figures == "triangle")
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine(num1 * num2 / 2);

        }
    }
}

