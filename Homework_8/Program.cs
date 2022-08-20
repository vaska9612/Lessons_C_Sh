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
            string[] directory = Directory.GetFiles(path);
            foreach (string file in directory)
            {
                Console.WriteLine(file);
                Directory.StreamReader 
            }
            Console.ReadKey();
        }
    }
}
