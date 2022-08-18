using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Чего больше в последовательности? Положительных чисел или отрицательных?
            int pos = 0;
            int neg = 0;
            int x;
            do
            {
                x = Convert.ToInt16(Console.ReadLine());
                if (x > 0)
                {
                    pos++;
                }
                if (x < 0)
                {
                    neg++;
                }
            } while (x != 0);
            if (pos > neg)
            {
                Console.WriteLine("В последовательности больше положительных чисел");
            }
            if (pos < neg)
            {
                Console.WriteLine("В последовательности больше отрицательных чисел");
            }                
            else
            {
                Console.WriteLine("В последовательности равное количество положительных и отрицательных чисел");
            }
            Console.ReadLine();
        }
    }
}
