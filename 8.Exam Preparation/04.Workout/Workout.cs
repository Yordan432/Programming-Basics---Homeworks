using System;
class Workout
{
    static void Main()
    {
        int numberOfDays = int.Parse(Console.ReadLine());
        double killometersFirstDay = double.Parse(Console.ReadLine());

        double days = killometersFirstDay;

        double total = 0;
        total += killometersFirstDay;
        for (int i = 0; i < numberOfDays; i++)
        {
            double profit = double.Parse(Console.ReadLine());
            double addProfit = days * (profit / 100);
            days += addProfit;
            total += days;
        }
        if (total < 1000)
        {
            double need = 1000 - total;
            Console.WriteLine("Sorry Mrs. Ivanova, you need to run {0} more kilometers", Math.Ceiling(need));
        }
        else
        {
            double need = Math.Ceiling(total - 1000);
            Console.WriteLine("You've done a great job running {0} more kilometers!" , need);
        }
    }
}
