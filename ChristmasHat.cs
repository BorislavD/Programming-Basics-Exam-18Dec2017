using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasHat
{
    class ChristmasHat
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write(new string('.', 2 * n - 1));
            Console.Write("/|\\");
            Console.WriteLine(new string('.', 2 * n - 1));

            Console.Write(new string('.', 2 * n - 1));
            Console.Write("\\|/");
            Console.WriteLine(new string('.', 2 * n - 1));

            Console.Write(new string('.', 2 * n - 1));
            Console.Write("***");
            Console.WriteLine(new string('.', 2 * n - 1));

            for (int i = 0; i < 2 * n - 1; i++)
            {
                Console.Write(new string('.', 2 * n - 2 - i));
                Console.Write("*");
                Console.Write(new string('-', 1 + i));
                Console.Write("*");
                Console.Write(new string('-', 1 + i));
                Console.Write("*");
                Console.WriteLine(new string('.', 2 * n - 2 - i));
            }

            Console.WriteLine(new string('*', 4 * n + 1));
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 4 * n + 1; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();

            }

            Console.WriteLine(new string('*', 4 * n + 1));
        }
    }
}
