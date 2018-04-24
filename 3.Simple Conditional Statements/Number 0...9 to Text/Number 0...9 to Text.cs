using System;
class Number09toText
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        string result = "";
        if (number == 1)
        {
            result = "one";
        }
        else if(number == 2)
        {
            result = "two";
        }
        else if(number == 3)
        {
            result = "three";
        }
        else if(number == 4)
        {
            result = "four";
        }
        else if(number == 5)
        {
            result = "five";
        }
        else if (number == 6)
        {
            result = "six";
        }
        else if (number == 7)
        {
            result = "seven";
        }
        else if (number == 8)
        {
            result = "eight";
        }
        else if (number == 9)
        {
            result = "nine";
        }
        else
        {
            result = "number too big";
        }
        Console.WriteLine(result);
    }
}

