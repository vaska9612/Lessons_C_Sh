using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle_Length(12);
            Circle_Area(12);
            Circle_Point_Belong(0, 0, 5, 10, 1);
        }
        static void Circle_Length(int R)
        {
            double L = 2 * Math.PI * R;
            Console.WriteLine("Длина окружности L = {0}", L);
        }
        static void Circle_Area(int R)
        {
            double S = Math.PI * R * R;
            Console.WriteLine("Площадь окружности S = {0}", S);
        }
        static void Circle_Point_Belong(int x0, int y0, int r, int x, int y)
        {
        bool point_in_circle = true;
           int X = x - x0;
           int Y = y - y0;
            if (Math.Sqrt(X*X + Y*Y) > r)
            {
                point_in_circle = false;
                Console.WriteLine("Точка не принадлежит кругу");
            }
            else
            {
                Console.WriteLine("Точка принадлежит кругу");
            }
            Console.ReadKey();

        }
    }
}
