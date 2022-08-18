using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5._2
{
    internal class Program
    {
        // Программа генерирует список из 10 случайных чисел, затем сортирует первые 5 по возрастанию, последние 5 - по убыванию
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                for (int j = i+1; j < 5; j++)
                {
                    if (array[i] > array[j])
                    {
                        int x = array[i];
                        array[i] = array[j];
                        array[j] = x;
                    }
                }
                
            }
            for (int i = 5; i < 9; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (array[i] < array[j])
                    {
                        int x = array[i];
                        array[i] = array[j];
                        array[j] = x;
                    }
                }
            }
            foreach (int i in array)
            {
                Console.Write("{0} ", i);
            }
            Console.ReadKey();
        }
    }
}
