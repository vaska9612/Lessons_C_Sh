using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2._1
{
    internal class Program
    {// Определение периметра и площади прямоугольника по координатам его вершин (x1, x2, y1, y2)
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x1");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y1");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите x2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y2");
            double y2 = Convert.ToDouble(Console.ReadLine());
            double P = (Math.Abs(x2 - x1) + Math.Abs(y2 - y1)) * 2;
            double S = Math.Abs((x2 - x1) * (y2 - y1));

            Console.WriteLine("периметр = {0}, площадь = {1}", P, S);
            Console.ReadKey();
        }
    }
}
