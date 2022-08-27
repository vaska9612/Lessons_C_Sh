using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework_8._1
{
    //Программно создайте текстовый файл и запишите в него 10 случайных чисел
    //Затем программно откройте созданный файл, рассчитайте сумму чисел в нем, ответ выведите на консоль
    internal class Program
    {
        static void Main(string[] args)
        {
            File.Create("D:/vaska/Desktop/C#/HW_8.1/numbers.txt").Close();
            int[] numbers = new int[10];
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next();
                using (StreamWriter sw = new StreamWriter("D:/vaska/Desktop/C#/HW_8.1/numbers.txt", true))
                {
                    sw.WriteLine("число N{0} = {1}", (i+1), numbers[i]);
                }
                
            }


        }
    }
}
