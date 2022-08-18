using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Sum = 1000;
            double p = 4;
            int i = 0;
            while (Sum < 2* Sum)
            {
                Sum += Sum * 0.04;
                i++;
            }
            Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
