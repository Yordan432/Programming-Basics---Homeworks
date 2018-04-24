using System;
using System.Globalization;

class DaysonEarth1000
{
    static void Main()
    {
        string date = Console.ReadLine();

        DateTime dt = DateTime.ParseExact(date , "dd-MM-yyyy" , CultureInfo.InvariantCulture);

        DateTime result = dt.AddDays(999);
        int day = result.Day;
        int month = result.Month;
        int year = result.Year;

        Console.WriteLine("{0}-{1}-{2}" , day.ToString("D2") , month.ToString("D2") , year);
    }
}
