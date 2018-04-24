using System;
class IsPrimeNumber
{
    public static bool isPrime(int lastDigit)
    {
        double divider = 2;
        double sqrNumber = Math.Sqrt(lastDigit);

        for (int i = 0; i < sqrNumber; i++)
        {
            if (divider % lastDigit == 0)
            {
                return false;
            }
            divider++;
        }
        return true;
    }

    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        if (number <=1)
        {
            Console.WriteLine("Not prime");
            return;
        }

        int sqr = (int)Math.Sqrt(number);

        bool isPrimeNumber = true;
        int divider = 2;
        for (int i = 2; i <=sqr; i++)
        {
            if (number % divider == 0)
            {
                isPrimeNumber = false;
                break;
            }
            divider++;
        }

        var result = isPrimeNumber == true ? "Prime" : "Not prime";
        Console.WriteLine(result);
    }
}

