using System;
class TheSameWords
{
    static void Main()
    {
        string firstWord = Console.ReadLine().ToLower();
        string secondWord = Console.ReadLine().ToLower();

        if (firstWord == secondWord)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}

