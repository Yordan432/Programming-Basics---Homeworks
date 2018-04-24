using System;
class FruitShop
{
    static void Main()
    {
        string fruit = Console.ReadLine();
        string dayOfWeek = Console.ReadLine();
        double amount = double.Parse(Console.ReadLine());

        double bananaPriceWeek = 2.50;
        double applePriceWeek = 1.20;
        double orangePriceWeek = 0.85;
        double grapefruitPriceWeek = 1.45;
        double kiwiPriceWeek = 2.70;
        double pineapplePriceWeek = 5.50;
        double grapesPriceWeek = 3.85;

        double bananaPriceWeekend = 2.70;
        double applePriceWeekend = 1.25;
        double orangePriceWeekend = 0.90;
        double grapefruitPriceWeekend = 1.60;
        double kiwiPriceWeekend = 3.00;
        double pineapplePriceWeekend = 5.60;
        double grapesPriceWeekend = 4.20;

        double price = 0.0;

        if (dayOfWeek == "Monday" || 
            dayOfWeek == "Tuesday"|| 
            dayOfWeek == "Wednesday" || 
            dayOfWeek == "Thursday" || 
            dayOfWeek == "Friday")
        {
            switch (fruit)
            {
                case "banana":
                    price = bananaPriceWeek;
                    break;
                case "apple":
                    price = applePriceWeek;
                    break;
                case "orange":
                    price = orangePriceWeek;
                    break;
                case "grapefruit":
                    price = grapefruitPriceWeek;
                    break;
                case "kiwi":
                    price = kiwiPriceWeek;
                    break;
                case "pineapple":
                    price = pineapplePriceWeek;
                    break;
                case "grapes":
                    price = grapesPriceWeek;
                    break;
            }
        }
        else if(dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
        {
            switch (fruit)
            {
                case "banana":
                    price = bananaPriceWeekend;
                    break;
                case "apple":
                    price = applePriceWeekend;
                    break;
                case "orange":
                    price = orangePriceWeekend;
                    break;
                case "grapefruit":
                    price = grapefruitPriceWeekend;
                    break;
                case "kiwi":
                    price = kiwiPriceWeekend;
                    break;
                case "pineapple":
                    price = pineapplePriceWeekend;
                    break;
                case "grapes":
                    price = grapesPriceWeekend;
                    break;
            }
        }
        else
        {
            Console.WriteLine("error");
            return;
        }
        if (price == 0.0)
        {
            Console.WriteLine("error");
        }
        else
        {
            Console.WriteLine("{0:f2}", price * amount);
        }
        
    }
}

