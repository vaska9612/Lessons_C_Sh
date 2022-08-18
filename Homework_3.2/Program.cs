using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите возраст в годах");
            int Age = Convert.ToByte(Console.ReadLine());
            // Проверка исходных данных (возраст от 20 до 69)
            if (Age >=20 && Age <= 69)
            {
                string dec = "..."; // Почему-то не работает, если ничего не присвоить переменной
                string ed = "...";
                #region // Определение названия десятка
                switch ((Age - Age % 10) / 10)
                {
                    case 2:
                        {
                            dec = "двадцать";
                            break;
                        }
                    case 3:
                        {
                            dec = "тридцать";
                            break;
                        }
                    case 4:
                        {
                            dec = "сорок";
                            break;
                        }
                    case 5:
                        {
                            dec = "пятьдесят";
                            break;
                        }
                    case 6:
                        {
                            dec = "шестьдесят";
                            break;
                        }
                }
                #endregion
                #region // Определение названия единиц
                switch (Age % 10)
                {
                    case 1:
                        {
                            ed = "один год";
                            break;
                        }
                    case 2:
                        {
                            ed = "два года";
                            break;
                        }
                    case 3:
                        {
                            ed = "три года";
                            break;
                        }
                    case 4:
                        {
                            ed = "четыре года";
                            break;
                        }
                    case 5:
                        {
                            ed = "пять лет";
                            break;
                        }
                    case 6:
                        {
                            ed = "шесть лет";
                            break;
                        }
                    case 7:
                        {
                            ed = "семь лет";
                            break;
                        }
                    case 8:
                        {
                            ed = "восемь лет";
                            break;
                        }
                    case 9:
                        {
                            ed = "девять лет";
                            break;
                        }
                    default:
                        {
                            ed = "лет";
                            break;
                        }
                }
                #endregion
                Console.WriteLine("{0} {1}", dec, ed);
            }
            else
            {
                Console.WriteLine("Веденный возраст не соответствует промежутку 20-69 лет");
            }
            Console.ReadLine();
        }
    }
}
