using System;
class NewYearsEveParty
{
    static void Main(string[] args)
    {
        int numbersOfPeople = int.Parse(Console.ReadLine());
        int moneyFamily = int.Parse(Console.ReadLine());


        double priceKyvert = 20 * numbersOfPeople;
        if (priceKyvert <=moneyFamily)
        {
            double remainder = moneyFamily - priceKyvert;
            double priceFireworks = 0.40 * remainder;
            double priceDonation = remainder - priceFireworks;

            Console.WriteLine("Yes! {0:f0} lv are for fireworks and {1:f0} lv are for donation." , priceFireworks , priceDonation);
        }
        else
        {
            double needMoney = priceKyvert - moneyFamily;
            Console.WriteLine("They won't have enough money to pay the covert. They will need {0:f0} lv more." ,needMoney);
        }
    }
}

