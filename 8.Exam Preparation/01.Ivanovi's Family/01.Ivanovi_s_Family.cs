using System;
class IvanovisFamilyram
{
    static void Main()
    {
        double money = double.Parse(Console.ReadLine());
        double pricePerGiftFirstChild = double.Parse(Console.ReadLine());
        double pricePerGiftSecondChild = double.Parse(Console.ReadLine());
        double pricePerGiftThirdChild = double.Parse(Console.ReadLine());

        double totalSumPerGift = pricePerGiftFirstChild + pricePerGiftSecondChild + pricePerGiftThirdChild;
        double profit = money - totalSumPerGift;
        double totalProfit = profit - (profit * 0.10);

        Console.WriteLine("{0:f2}" , totalProfit);
    }
}

