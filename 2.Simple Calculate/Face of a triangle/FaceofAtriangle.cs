using System;
class FaceofAtriangle
{
    static void Main()
    {
        double side = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double area = side * height / 2;

        Console.WriteLine("Triangle area = {0}" , area);
    }
}

