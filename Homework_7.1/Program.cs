using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7._1
{
    // Программа вычисляет объем и площадь поверхности куба по длине его ребра
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба");
            int a = Convert.ToInt16(Console.ReadLine());
            VolumeArea(a);
            Console.ReadKey();
        }
        static void VolumeArea (int a)
        {
            int V = a * a * a;
            int S = 6 * a * a;
            Console.WriteLine("V = {0}, S_пов = {1}", V, S);
        }
    }
}
