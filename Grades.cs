using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Grades
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double numberOfTopStudents = 0;
            double numberBetween4And499Vkljuchitelno = 0;
            double numberBetween3And399Vkljuchitelno = 0;
            double fail = 0;
            double sumOfAllGrade = 0.00;
            for (int i = 0; i < n; i++)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade >= 5.00)
                {
                    numberOfTopStudents++;
                    sumOfAllGrade += grade;
                }
                else if (grade >= 4.00 && grade <= 4.99)
                {
                    numberBetween4And499Vkljuchitelno++;
                    sumOfAllGrade += grade;
                }
                else if (grade >= 3.00 && grade <= 3.99)
                {
                    numberBetween3And399Vkljuchitelno++;
                    sumOfAllGrade += grade;
                }
                else
                {
                    fail++;
                    sumOfAllGrade += grade;
                }
            }

            Console.WriteLine();

            double average = sumOfAllGrade / n;

            double result1 = (numberOfTopStudents / n) * 100;
            double result2 = (numberBetween4And499Vkljuchitelno / n) * 100;
            double result3 = (numberBetween3And399Vkljuchitelno / n) * 100;
            double result4 = (fail / n) * 100;

            Console.WriteLine("Top students: {0:f2}%", result1);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", result2);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", result3);
            Console.WriteLine("Fail: {0:f2}%", result4);
            Console.WriteLine("Average: {0:f2}", average);
        }
    }
}
