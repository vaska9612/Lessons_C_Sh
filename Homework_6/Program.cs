using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Программа находит самое длинное слово в строке
            string S = Console.ReadLine();
            string[] subs = S.Split(' ');
            int max_length = 0;
            string word = " "; // Попробовать создать строку через String.Builder
            foreach (string sub in subs)
            {
                if (sub.Length > max_length)
                {
                    max_length = sub.Length;
                    word = sub;
                }
            }
            Console.WriteLine("Самое длинное слово в строке - {0}", word);
            Console.ReadKey();
        }
    }
}
