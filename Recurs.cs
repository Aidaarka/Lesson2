using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2
{
    class Recurs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            double n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите степень: ");
            double p = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Power(n, p));
        }

        static double Power(double number, double pow)
        {
            if (pow == 0)
            {
                return 1;
            }
            else if (pow > 0)
            {
                return Power(number, pow - 1) * number;
            }
            else
                return (double)(1.0 / Power(number, -pow));
        }
    }
}
