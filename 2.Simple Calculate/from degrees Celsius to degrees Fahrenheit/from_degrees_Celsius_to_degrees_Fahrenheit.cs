using System;
class from_degrees_Celsius_to_degrees_Fahrenheit
{
    static void Main()
    {
        double degrees = double.Parse(Console.ReadLine());

        double celsius = degrees * 1.8 + 32;
        Console.WriteLine(celsius);
    }
}

