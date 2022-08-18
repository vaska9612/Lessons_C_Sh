using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Program
    {
        //Программа определяет модуль числа
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int absNumber;
            if (number > 0)
            {
                absNumber = number;
            }
            else
            {
                absNumber = -number;
            }
            Console.WriteLine(absNumber);
            Console.ReadKey();
        }
    }
}
