using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeTiles
{
    class ChangeTiles
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            decimal floorWidth = decimal.Parse(Console.ReadLine());
            decimal floorLength = decimal.Parse(Console.ReadLine());
            decimal triangleSide = decimal.Parse(Console.ReadLine());
            decimal triangleHeight = decimal.Parse(Console.ReadLine());
            decimal plochkaPrice = decimal.Parse(Console.ReadLine());
            decimal sumaMaistor = decimal.Parse(Console.ReadLine());

            decimal floorArea = floorWidth * floorLength;
            decimal plochkaArea = triangleSide * triangleHeight / 2;
            decimal plochkaRequired = Math.Ceiling(floorArea / plochkaArea + 5);
            decimal sumaPlochki = plochkaPrice * plochkaRequired + sumaMaistor;

            if (money >= sumaPlochki)
            {
                Console.WriteLine("{0:f2} lv left.", money - sumaPlochki);

            }
            else
            {
                Console.WriteLine("You'll need {0:f2} lv more.", sumaPlochki - money);
            }
        }
    }
}
