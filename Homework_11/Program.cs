using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11
{
    internal class Program
    {
        //Разработать структуру для решения линейного уравнения 0=kx+b. Коэффициенты уравнения k, b реализовать с помощью полей вещественного типа.
        //Для решения уравнения предусмотреть метод Root. Создать экземпляр разработанной структуры.
        //Осуществить использование экземпляра в программе.
        static void Main(string[] args)
        {
            Equation equation = new Equation();
            Console.WriteLine("Введите k");
            int k = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите b");
            int b = Convert.ToInt16(Console.ReadLine());
            equation.Root(b, k);
            Console.ReadKey();
        }
        struct Equation
        {
            public int k;  //Нормально ли, что тут int, а в аргументах метода double. Если аргументы делать int, то в ответе х получается целым всегда
            public int b;
            public void Root(double b, double k)
            {
                double x = -(b / k);
                Console.WriteLine("х = {0}", x);
            }
        }

    }
}
