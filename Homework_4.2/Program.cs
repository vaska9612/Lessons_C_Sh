using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Определение числа квадратов со стороной С, которое поместится в прямоугольнике со сторонами А и В
            int A = Convert.ToUInt16(Console.ReadLine());
            int B = Convert.ToUInt16(Console.ReadLine());
            int C = Convert.ToUInt16(Console.ReadLine());
            int numb = 0;
            int a = 0;
            int b = 0;
            while (b <= (B-C))
            {
                while (a <= (A-C))
                {
                    a += C;
                    numb++;
                }
                b += C;
                numb++;
            }
            Console.WriteLine("Количество квадратов, размещенных в прямоугольнике: {0}", numb);
            Console.ReadKey();
        }
    }
}
