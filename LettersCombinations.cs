using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersCombinations
{
    class LettersCombinations
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            string third = Console.ReadLine();
            int count = 0;
            for (char i = char.Parse(first); i <= char.Parse(second); i++)
            {
                for (char j = char.Parse(first); j <= char.Parse(second); j++)
                {
                    for (char k = char.Parse(first); k <= char.Parse(second); k++)
                    {
                        if (i != char.Parse(third) && j != char.Parse(third) && k != char.Parse(third))
                        {
                            Console.Write("{0}{1}{2} ", i, j, k);
                            count++;

                        }
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
