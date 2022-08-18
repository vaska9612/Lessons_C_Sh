using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2._2
{
    internal class Program
    {//Нахождение периметра P и площади S треугольника по координатам трех его вершин (x1, y1, x2, y2, x3, y3)
        static void Main(string[] args)
        {
            Console.WriteLine("введите x1");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите y1");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите x2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите y2");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите x3");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите y3");
            double y3 = Convert.ToDouble(Console.ReadLine());
            double a = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            double b = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
            double c = Math.Sqrt(Math.Pow((x1 - x3), 2) + Math.Pow((y1 - y3), 2));
            double p = (a + b + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            double P = a + b + c;
            Console.WriteLine("площадь = {0}, периметр = {1}", S, P);
            Console.ReadKey();
        }
    }
}
