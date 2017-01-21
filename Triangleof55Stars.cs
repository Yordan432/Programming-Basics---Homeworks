using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangleof55Stars
{
    class Triangleof55Stars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 0; row <=n; row++)
            {
                for (int i = 0; i <= row; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
        }
    }
}
