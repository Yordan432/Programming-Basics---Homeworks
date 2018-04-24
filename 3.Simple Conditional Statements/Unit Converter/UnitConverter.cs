using System;
class UnitConverter
{
    static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        string output = Console.ReadLine();

        double mm = 1000;
        double cm = 100;
        double mi = 0.000621371192;
        double inch = 39.3700787;
        double km = 0.001;
        double ft = 3.2808399;
        double yd = 1.0936133;
        double m = 1.0;

        if (input == "mm"){ number /= mm; }
        else if(input == "cm"){  number /= cm;}
        else if(input == "mi"){ number /= mi;}
        else if(input == "in"){ number /= inch;}
        else if(input == "km"){ number /= km;}
        else if(input == "ft"){ number /= ft;}
        else if(input == "yd"){ number /= yd;}
        else if (input == "m") { number /= m; }

        if (output == "mm"){number *= mm;}
        else if(output == "cm"){number *= cm;}
        else if(output == "mi"){number *= mi;}
        else if(output == "in"){number *= inch;}
        else if(output == "km"){number *= km;}
        else if(output == "ft"){ number *= ft;}
        else if(output == "yd"){number *= yd;}
        else if (output == "m") { number *= m; }

        Console.WriteLine("{0} {1}" , number , output);
    }
}

