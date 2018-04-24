using System;
class Trade_Comissions
{
    static void Main()
    {
        string city = Console.ReadLine();
        double sale = double.Parse(Console.ReadLine());

        double profit = 0.0;
        if (city == "Sofia")
        {
            if (sale > 0 && sale <=500)
            {
                profit = 0.05;
            }
            else if(sale > 500 && sale <= 1000)
            {
                profit = 0.07;
            }
            else if(sale > 1000 && sale <= 10000)
            {
                profit = 0.08;
            }
            else if(sale > 10000)
            {
                profit = 0.012;
            }
        }
        else if(city == "Varna")
        {
            if (sale > 0 && sale <= 500)
            {
                profit = 0.045;
            }
            else if (sale > 500 && sale <= 1000)
            {
                profit = 0.075;
            }
            else if (sale > 1000 && sale <= 10000)
            {
                profit = 0.10;
            }
            else if (sale > 10000)
            {
                profit = 0.13;
            }
        }
        else if(city == "Plovdiv")
        {
            if (sale > 0 && sale <= 500)
            {
                profit = 0.055;
            }
            else if (sale > 500 && sale <= 1000)
            {
                profit = 0.08;
            }
            else if (sale > 1000 && sale <= 10000)
            {
                profit = 0.12;
            }
            else if (sale > 10000)
            {
                profit = 0.145;
            }
        }
        if (profit > 0)
        {
            Console.WriteLine("{0:f2}", sale * profit);
        }
        else
        {
            Console.WriteLine("error");
        }
       
    }
}

