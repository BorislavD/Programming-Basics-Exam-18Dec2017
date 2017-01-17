using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    class Distance
    {
        static void Main(string[] args)
        {
            int speedFirst = int.Parse(Console.ReadLine());
            int timeFirstMinutes = int.Parse(Console.ReadLine());
            int timeSecondMinutes = int.Parse(Console.ReadLine());
            int timeThirdMinutes = int.Parse(Console.ReadLine());

            double timeFirstHours = timeFirstMinutes / 60.00;
            double timeSecondHours = timeSecondMinutes / 60.00;
            double timeThirdHours = timeThirdMinutes / 60.00;

            double speedSecond = speedFirst * 1.10;
            double speedThird = speedSecond * 0.95;

            double raztojanieFirst = speedFirst * timeFirstHours;
            double raztojanieSecond = speedSecond * timeSecondHours;
            double raztojanieThird = speedThird * timeThirdHours;

            double raztojanieTotal = raztojanieFirst + raztojanieSecond + raztojanieThird;

            Console.WriteLine("{0:f2}", raztojanieTotal);
        }
    }
}
