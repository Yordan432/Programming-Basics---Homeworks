using System;
class Of_radians_in_degrees
{
    static void Main()
    {
        double radians = double.Parse(Console.ReadLine());

        double degrees = radians * 180 / Math.PI;

        Console.WriteLine((int)degrees);
    }
}

