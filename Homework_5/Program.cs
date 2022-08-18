using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    internal class Program
    {
        // Программа находит среднее арифметическое семи чисел
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 7 чисел через enter");
            float Sum = 0;
            int[] array = new int[7];
            for (int i = 0; i < 7; i++)
            {
                array[i] = Convert.ToInt16(Console.ReadLine());
                Sum += array[i];
            }
            Console.WriteLine("Среднее арифметическое введенных семи чисел равно {0}", Sum/7);
            Console.ReadKey();

        }
    }
}
