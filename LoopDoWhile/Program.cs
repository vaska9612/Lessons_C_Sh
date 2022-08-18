using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            double Sum = 1000;
            double Sum2 = Sum * 2;
            do
            {
                i++;
                Sum += Sum * 0.04;
            } while (Sum < Sum2);
            Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
