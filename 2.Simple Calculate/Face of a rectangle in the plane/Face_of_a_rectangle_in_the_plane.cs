using System;
class Face_of_a_rectangle_in_the_plane
{
    static void Main()
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        double withd = Math.Max(x1, x2) - Math.Min(x1 , x2);
        double heigth = Math.Max(y1, y2) - Math.Min(y2, y2);

        double area = withd * heigth;
        double perimeter = 2 * (withd + heigth);

        Console.WriteLine(area);
        Console.WriteLine(perimeter);
    }
}

