using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7
{
    internal class Program
    {
        // Программа сравнивает площади двух треугольников, используются Методы
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины сторон первого треугольника");
            int a1 = Convert.ToInt16(Console.ReadLine());
            int b1 = Convert.ToInt16(Console.ReadLine());
            int c1 = Convert.ToInt16(Console.ReadLine());
            int a2, b2, c2;
            a2 = b2 = c2 = 0;
            bool Q = true;
            if (((a1 + b1) <= c1 || (b1 + c1) <= a1 || (a1 + c1) <= b1))
            {
               Q = false;
               Console.WriteLine("Такого треугольника не существует");
            }
            else
            {
                Console.WriteLine("Введите длины сторон второго треугольника");
                a2 = Convert.ToInt16(Console.ReadLine());
                b2 = Convert.ToInt16(Console.ReadLine());
                c2 = Convert.ToInt16(Console.ReadLine());
                if (((a2 + b2) <= c2 || (b2 + c2) <= a2 || (a2 + c2) <= b2))
                {
                    Q = false;
                    Console.WriteLine("Такого треугольника не существует");
                }
            }
            if (Q == true)
            {
                double S1 = CalcArea(a1, b1, c1);
                double S2 = CalcArea(a2, b2, c2);
                if (S1 > S2)
                {
                    Console.WriteLine("Площадь первого треугольника больше");
                }
                else
                {
                    Console.WriteLine("Площадь второго треугольника больше");
                }
            }
            else
                Console.WriteLine("Ошибка в исходных данных. Программа не выполнена");
            Console.ReadKey();
        }
        static double CalcArea(int a, int b, int c)
        {
            double p = (double) (a + b + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine(S);
            return S;
        }

    }
}
