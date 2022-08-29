using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework_8._2
{
    //Вручную подготовьте текстовый файл с фрагментом текста
    //Напишите программу, которая выводит статистику по файлу - количество символов, строк и слов в тексте
    internal class Program
    {
        static void Main(string[] args)
        {
            string file_path = "D:/vaska/Desktop/C#/HW_8.2/Text.txt";
            using (StreamReader reader = new StreamReader(file_path))
            {
                string text = reader.ReadToEnd();
                int numb_symbol = text.Length;
                Console.WriteLine(numb_symbol);
            }
            using (StreamReader reader = new StreamReader(file_path))
            {
                string line;
                int numb_lines = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    numb_lines++;
                }
                Console.WriteLine(numb_lines);
            }
            using (StreamReader reader = new StreamReader(file_path))
            {
                int numb_words = 0;
                string text = reader.ReadLine();
                while (text != null)
                {
                    text = text.Replace(" - ", " ");
                    string[] words = text.Split(' ');
                    numb_words += words.Length;
                    text = reader.ReadLine();
                }
                numb_words = numb_words;
                Console.WriteLine(numb_words);
            }
                Console.ReadKey();
        }
    }
}
