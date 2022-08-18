using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Программа определяет квадрат числа N > 0
            int N = Convert.ToUInt16(Console.ReadLine());
                int pow = 0;
           for (int i = 1; i <= N; ++i)
            {
                pow += 2 * i - 1;
                Console.WriteLine(pow);
            }
           Console.ReadKey();

        }
    }
}
