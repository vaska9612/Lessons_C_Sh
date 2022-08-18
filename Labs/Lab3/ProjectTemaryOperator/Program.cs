using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTemaryOperator
{
    internal class Program
    {
        // Программа находит наибольшее из двух чисел
        static void Main(string[] args)
        {
          int x1 = Convert.ToInt32(Console.ReadLine());
          int x2 = Convert.ToInt32(Console.ReadLine());
          int max = (x1 > x2)? x1 : x2;
          Console.WriteLine(max);
          Console.ReadKey();
        }
    }
}
