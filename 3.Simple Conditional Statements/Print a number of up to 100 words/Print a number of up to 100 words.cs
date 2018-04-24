using System;
using System.Text;

class PrintANumberOfUpTo100Words
{
    static void Main()
    {
        int readNumber = int.Parse(Console.ReadLine());
        int number = readNumber;

        string firstWord = "";
        string lastWord = "";
        int units = number % 10;
        number /= 10;

        int tens = number % 10;
        number /= 10;

        int hundres = number;

        if (readNumber == 0)
        {
            Console.WriteLine("zero");
            return;
        }

        if (readNumber < 0 || readNumber > 100)
        {
            Console.WriteLine("invalid number");
            return;
        }

        if (readNumber >= 10 && readNumber <= 20)
        {
            if (readNumber == 10)
            {
                firstWord = "ten";
            }
            else if (readNumber == 11)
            {
                firstWord = "eleven";
            }
            else if (readNumber == 12)
            {
                firstWord = "twelve";
            }
            else if (readNumber == 13)
            {
                firstWord = "thirteen";
            }
            else if (readNumber == 14)
            {
                firstWord = "fourteen";
            }
            else if (readNumber == 15)
            {
                firstWord = "fifteen";
            }
            else if (readNumber == 16)
            {
                firstWord = "sixteen";
            }
            else if (readNumber == 17)
            {
                firstWord = "seventeen";
            }
            else if (readNumber == 18)
            {
                firstWord = "eighteen";
            }
            else if (readNumber == 19)
            {
                firstWord = "nineteen";
            }
            else if (readNumber == 20)
            {
                firstWord = "twenty";
            }
        }
        else
        {
            if (tens == 2)
            {
                firstWord = "twenty";
            }
            else if (tens == 3)
            {
                firstWord = "thirty";
            }
            else if (tens == 4)
            {
                firstWord = "forty";
            }
            else if (tens == 5)
            {
                firstWord = "fifty";
            }
            else if (tens == 6)
            {
                firstWord = "sixty";
            }
            else if (tens == 7)
            {
                firstWord = "seventy";
            }
            else if (tens == 8)
            {
                firstWord = "eighty";
            }
            else if (tens == 9)
            {
                firstWord = "ninety";
            }


            if (units == 1)
            {
                lastWord = "one";
            }
            else if (units == 2)
            {
                lastWord = "two";
            }
            else if (units == 3)
            {
                lastWord = "three";
            }
            else if (units == 4)
            {
                lastWord = "four";
            }
            else if (units == 5)
            {
                lastWord = "five";
            }
            else if (units == 6)
            {
                lastWord = "six";
            }
            else if (units == 7)
            {
                lastWord = "seven";
            }
            else if (units == 8)
            {
                lastWord = "eight";
            }
            else if (units == 9)
            {
                lastWord = "nine";
            }
            else if (units == 0)
            {
                lastWord = "";
            }

            if (hundres != 0)
            {
                firstWord = "hundred";

            }

        }
        if (readNumber >= 10 && readNumber <= 20)
        {
            Console.WriteLine("{0}" , firstWord);
        }
        else
        {
            Console.WriteLine("{0} {1}" , firstWord , lastWord);
        }
    }
}

