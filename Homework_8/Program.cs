using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework_8
{
    internal class Program
    {
        // Работа с файлами
        //Выберите любую папку на своем компьютере, имеющую вложенные директории. Выведите на консоль ее содержимое и содержимое всех подкаталогов.
        static void Main(string[] args)
        {
            string path = "D:/vaska/Desktop/C#/HW_8";
            string[] main_directory = Directory.GetDirectories(path);
            string[] sub_directory;
            int i = 0;
            int j = 0;
            foreach (string directory in main_directory)
            {
                i++;
                j = 0;
                Console.WriteLine();
                Console.WriteLine("путь вложенной папки N{0}: {1}", i, directory);
                sub_directory = Directory.GetFiles(directory);
                foreach (string file in sub_directory)
                {
                    j++;
                    Console.WriteLine("путь файла N{0} вложенной папки N{1}: {2}",j, i, file);
                }
            }            
            Console.ReadKey();
        }
    }
}
