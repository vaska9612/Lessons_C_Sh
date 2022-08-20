using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6._1
{
    internal class Program
    {
        // Программа определяет является ли вводимая строка палиндромом (без учета пробелов и регистра)
        static void Main(string[] args)
        {
            string S1 = (Console.ReadLine()).ToLower();
            S1 = S1.Replace(" ", "");
            StringBuilder S2 = new StringBuilder();
            for (int i = (S1.Length - 1); i >= 0; i--)
            {
                if (!S1[i].Equals(' '))
                {
                    string elem = S1.Substring(i, 1);S2.Append(S1[i]);
                }
            }
            /*Console.WriteLine(S1.ToString());
            Console.WriteLine(S2.ToString());*/
            if (S1.Equals(S2.ToString()))
                Console.WriteLine("Строка является палиндромом");
            else
                Console.WriteLine("Строка не является палиндромом");
            Console.ReadKey();
        }
    }
}
