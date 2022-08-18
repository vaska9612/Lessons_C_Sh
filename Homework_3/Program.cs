using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    internal class Program
    {
        // Программа находит координаты четвертой вершины прямоугольника
        static void Main(string[] args)
        {
            Console.WriteLine("Введите х1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите х2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y2");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите х3");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y3");
            int y3 = Convert.ToInt32(Console.ReadLine());

            #region
            // Проверка корректности исходных данных
            if (Math.Abs((x1 - x2) * (x1 - x3) * (x2 - x3)) + Math.Abs((y1 - y2) * (y1 - y3) * (y2 - y3)) != 0)
            {
                Console.WriteLine("Ошибка!: Нельзя получить прямоугольник со сторонами, параллельными координатным осям");                
            }
            else
            {
                if ((x1 == x2 && y1 == y2) || (x2 == x3 && y2 == y3) || (x1 == x3 && y1 == y3))
                {
                    Console.WriteLine("Ошибка!: Точки не должны совпадать");
                }
                #endregion
                else
                {
                    int x4, y4;
                    x4 = (x1 == x2) ? x3 : (x1 == x3) ? x2 : x1;
                    y4 = (y1 == y2) ? y3 : (y1 == y3) ? y2 : y1;
                    Console.WriteLine("x4 = {0}, y4 = {1}", x4, y4);
                }
            }            
            Console.ReadKey();
        }
    }
}
