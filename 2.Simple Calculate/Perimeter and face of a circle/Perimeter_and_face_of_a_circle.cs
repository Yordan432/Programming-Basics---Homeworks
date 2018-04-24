using System;
class Perimeter_and_face_of_a_circle
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());

        double area = Math.PI * r * r;
        double perimeter = 2 * Math.PI * r;

        Console.WriteLine(area);
        Console.WriteLine(perimeter);
    }
}

