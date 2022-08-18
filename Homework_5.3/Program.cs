using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5._3
{
    internal class Program
    {
        // Программа генерирует 20 случайных чисел от -50 до 50 и определяет количество нечетных положительных чисел, стоящих на четных местах
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[20];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            int num = 0;
            for (int i = 1; i < array.Length; i += 2)
            {
                if (array[i] % 2 != 0 && array[i] > 0)
                    num++;
            }
            Console.WriteLine("Количество нечетных положительных чисел, стоящих на четных местах равно {0}", num);
            Console.ReadLine();
        }
    }
}
