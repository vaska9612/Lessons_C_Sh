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
            string file_path = "D:/vaska/Desktop/C#/HW_8.1/numbers.txt";
            File.Create(file_path).Close();
            int[] numbers = new int[10];
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(0, 100);
                using (StreamWriter sw = new StreamWriter(file_path, true))
                {
                    sw.WriteLine("число N{0} = {1}", (i + 1), numbers[i]);
                }
            }
            StringBuilder sb = new StringBuilder();
            using (StreamReader sr = new StreamReader(file_path))
            {
                string line;
                int[] numbers_file = new int[10];
                int i = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    i++;
                    int index = line.LastIndexOf(" ");
                    line = line.Substring(index);
                    numbers_file[i] = Convert.ToInt32(line);
                }
            }
            Console.WriteLine(sb);
            Console.ReadKey();            


        }
        /*static int CulcSum(string file_path, out int Sum)
        {

        }*/


    }
}
