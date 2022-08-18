using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5._1
{
    internal class Program
    {
        // Программа генерирует список из 15 элементов от 0 до 50 и находит сумму максимального и минимального элементов
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[15];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            int max = array[0];
            foreach (int a in array)
            {
                if (a > max)
                {
                    max = a;
                }
            }
            int min = array[0];
            foreach (int a in array)
            {
                if (a < min)
                {
                    min = a;
                }
            }
            Console.WriteLine("Сумма максимального и минимального элементов массива равна {0}", max + min);
            Console.ReadKey();
        }
    }
}
