using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6._2
{
    // Программа удалаяет из строки фрагменты, заключенные в {}
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            while (text.IndexOf("{") != -1 && text.LastIndexOf("}") != -1 && text.IndexOf("{") < text.LastIndexOf("}"))
            {
                text = text.Remove(text.IndexOf("{"),(text.LastIndexOf("}") - text.IndexOf("{") + 1));
            }
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}
