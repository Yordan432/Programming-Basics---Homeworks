using System;
class IvanovisHoliday
{
    static void Main()
    {
        int numberOfNight = int.Parse(Console.ReadLine());
        string destination = Console.ReadLine();
        string transport = Console.ReadLine();

        double priceOld = 0.0;
        double priceChildren = 0.0;

        if (destination == "Miami")
        {
            if (numberOfNight >=1 && numberOfNight <=10)
            {
                priceOld = 24.99;
                priceChildren = 14.99;
            }
            else if(numberOfNight >=11 && numberOfNight <=15)
            {
                priceOld = 23.99;
                priceChildren = 11.99;
            }
            else
            {
                priceOld = 20.00;
                priceChildren = 10.00;
            }
        }
        else if (destination == "Canary Islands")
        {
            if (numberOfNight >=1 && numberOfNight <=10)
            {
                priceOld = 32.50;
                priceChildren = 28.50;
            }
            else if (numberOfNight >=11 && numberOfNight <=15)
            {
                priceOld = 30.50;
                priceChildren = 25.60;
            }
            else
            {
                priceOld = 28.00;
                priceChildren = 22.00;
            }
        }
        else if (destination == "Philippines")
        {
            if (numberOfNight >=1 && numberOfNight <=10)
            {
                priceOld = 42.99;
                priceChildren = 39.99;
            }
            else if (numberOfNight >=11 && numberOfNight <=15)
            {
                priceOld = 41.00;
                priceChildren = 36.00;
            }
            else
            {
                priceOld = 38.50;
                priceChildren = 32.40;
            }
        }
        // add 25 % for dog
        double transportOldPrice = 0;
        double transportChildrenPrice = 0;
        if (transport == "train")
        {
            transportOldPrice = 22.30;
            transportChildrenPrice = 12.50;
        }
        else if(transport == "bus")
        {
            transportOldPrice = 45.00;
            transportChildrenPrice = 37.00;
        }
        else
        {
            transportOldPrice = 90.00;
            transportChildrenPrice = 68.50;
        }

        double olds = 2 * priceOld;
        double youngs = 3 * priceChildren;


        double cost = numberOfNight * (olds + youngs);
        double profits = cost + (cost * 0.25);

        double costTransport = 2 * transportOldPrice + 3 * transportChildrenPrice;
        double result = costTransport + profits;
        Console.WriteLine("{0:f3}" , result);
    }
}

