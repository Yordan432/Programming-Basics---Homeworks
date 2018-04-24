using System;
class BonusScore
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        double bonusScore = 0;

        if (number <= 100)
        {
            bonusScore = 5;
        }
        else if(number > 100 && number <= 1000)
        {
            bonusScore = number * 0.20;
        }
        else if(number > 1000)
        {
            bonusScore = number * 0.10;
        }

        int lastDigit = number % 10;
        if (number % 2 == 0)
        {
            bonusScore += 1;
        }
        else if(lastDigit == 5)
        {
            bonusScore += 2;
        }

        Console.WriteLine(bonusScore);
        Console.WriteLine(number + bonusScore);
    }
}

