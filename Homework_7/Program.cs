using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины сторон первого треугольника");
            int a1 = Convert.ToInt16(Console.ReadLine());
            int b1 = Convert.ToInt16(Console.ReadLine());
            int c1 = Convert.ToInt16(Console.ReadLine());
            double S1 = 0;
            Console.WriteLine("Введите длины сторон второго треугольника");
            int a2 = Convert.ToInt16(Console.ReadLine());
            int b2 = Convert.ToInt16(Console.ReadLine());
            int c2 = Convert.ToInt16(Console.ReadLine());
            double S2 = 0;
            S1 = CalcArea(a1, b1, c1);
            S2 = CalcArea(a2, b2, c2);
            if (S1 > S2)
            {
                Console.WriteLine("Площадь первого треугольника больше");
            }
            else
            {
                if (S2 > S1)
                    Console.WriteLine("Площадь второго треугольника больше");
                else
                    Console.WriteLine("Площади треугольников равны");
            }           
                Console.ReadKey();
        }
        static double CalcArea(int a, int b, int c)
        {
            double p = (double) (a + b + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine(S);
            return S;
            //нифига не работает!!!
        }
    }
}
