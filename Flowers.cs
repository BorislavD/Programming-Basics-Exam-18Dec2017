using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
    class Flowers
    {
        static void Main(string[] args)
        {
            int hrizantemi = int.Parse(Console.ReadLine());
            int rozi = int.Parse(Console.ReadLine());
            int laleta = int.Parse(Console.ReadLine());
            string sezon = Console.ReadLine();
            string dayType = Console.ReadLine();
            decimal price = 0;

            switch (sezon)
            {
                case "Spring":
                    price = hrizantemi * 2.00M + rozi * 4.10M + laleta * 2.50M;
                    if (dayType == "Y")
                    {
                        price = price * 1.15M;
                    }

                    if (laleta > 7)
                    {
                        price = price * 0.95M;
                    }

                    if (hrizantemi + rozi + laleta > 20)
                    {
                        price = price * 0.8M;
                    }
                    break;

                case "Summer":
                    price = hrizantemi * 2.00M + rozi * 4.10M + laleta * 2.50M;
                    if (dayType == "Y")
                    {
                        price = price * 1.15M;
                    }

                    if (hrizantemi + rozi + laleta > 20)
                    {
                        price = price * 0.8M;
                    }
                    break;

                case "Winter":
                    price = hrizantemi * 3.75M + rozi * 4.50M + laleta * 4.15M;
                    if (dayType == "Y")
                    {
                        price = price * 1.15M;
                    }

                    if (rozi >= 10)
                    {
                        price = price * 0.9M;
                    }

                    if (hrizantemi + rozi + laleta > 20)
                    {
                        price = price * 0.8M;
                    }
                    break;

                case "Autumn":
                    price = hrizantemi * 3.75M + rozi * 4.50M + laleta * 4.15M;
                    if (dayType == "Y")
                    {
                        price = price * 1.15M;
                    }


                    if (hrizantemi + rozi + laleta > 20)
                    {
                        price = price * 0.8M;
                    }
                    break;
            }

            price += 2;

            Console.WriteLine("{0:f2}", price);

        }
    }
}
