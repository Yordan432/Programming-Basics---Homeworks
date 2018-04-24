using System;
class PersonalTitles
{
    static void Main()
    {
        double age = double.Parse(Console.ReadLine());
        string gender = Console.ReadLine().ToLower();

        if (gender == "m")
        {
            if (age < 16)
            {
                Console.WriteLine("Master");
            }
            else
            {
                Console.WriteLine("Mr.");
            }
        }
        else
        {
            if (age < 16)
            {
                Console.WriteLine("Miss");
            }
            else
            {
                Console.WriteLine("Ms.");
            }
        }
    }
}

