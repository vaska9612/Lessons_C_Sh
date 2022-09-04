using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            double a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите целое число");
            double b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Что с ними сделать?");
            Console.WriteLine("1 - сложить\n2 - вычесть из первого второе\n3 - перемножить\n4 - поделить первое на второе");
            int to_do = 0;
            try
            {
                to_do = Convert.ToInt16(Console.ReadLine());
                switch (to_do)
                {
                    case 1:
                        {
                            Console.WriteLine("Результат: {0}", a + b);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Результат: {0}", a - b);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Результат: {0}", a * b);
                            break;
                        }
                    case 4:
                        {                            
                            Console.WriteLine("Результат: {0}", a / b);
                            break;
                        }
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка! Делить на ноль нельзя!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка! Надо вводить именно целые числа!");
            }
            catch (Exception) when (to_do != 1 || to_do != 2 || to_do != 3 || to_do != 4)
            {
                Console.WriteLine("Ошибка! Нет функции с номером {0}", to_do);
            }
            Console.ReadKey();
        }
    }
}
