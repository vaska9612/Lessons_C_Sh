using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число от 100 до 999");
            int numb = Convert.ToInt16(Console.ReadLine());
            if (numb < 100 || numb > 999) // Проверка
            {
                Console.WriteLine("Неправильно. Попробуй еще раз");
            }
            else
            {
                string sot = "";
                string dec = "";
                string ed = "";
                #region // Определение названия сотен
                switch (decimal.Truncate(numb / 100))
                {
                    case 1:
                        {
                            sot = "сто";
                            break;
                        }
                    case 2:
                        {
                            sot = "двести";
                            break;
                        }
                    case 3:
                        {
                            sot = "триста";
                            break;
                        }
                    case 4:
                        {
                            sot = "четыреста";
                            break;
                        }
                    case 5:
                        {
                            sot = "пятьсот";
                            break;
                        }
                    case 6:
                        {
                            sot = "шестьсот";
                            break;
                        }
                    case 7:
                        {
                            sot = "семьсот";
                            break;
                        }
                    case 8:
                        {
                            sot = "восемьсот";
                            break;
                        }
                    case 9:
                        {
                            sot = "девятьсот";
                            break;
                        }
                }
                #endregion
                #region // Определение названия десятков
                switch (decimal.Truncate(numb / 10) % 10)
                {
                    case 0:
                        {
                            dec = "";
                            break;
                        }
                    case 1:
                        {
                            dec = "десять";
                            break;
                        }
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
                    case 7:
                        {
                            dec = "семьдесят";
                            break;
                        }
                    case 8:
                        {
                            dec = "восемьдесят";
                            break;
                        }
                    case 9:
                        {
                            dec = "девяносто";
                            break;
                        }
                }
                #endregion
                #region // Определение названия единиц
                if (dec == "десять")
                {
                    switch (numb % 10)
                    {
                        case 0:
                            {
                                ed = "";
                                break;
                            }
                        case 1:
                            {
                                dec = "одиннадцать";
                                break;
                            }
                        case 2:
                            {
                                dec = "двенадцать";
                                break;
                            }
                        case 3:
                            {
                                dec = "тринадцать";
                                break;
                            }
                        case 4:
                            {
                                dec = "четырнадцать";
                                break;
                            }
                        case 5:
                            {
                                dec = "пятнадцать";
                                break;
                            }
                        case 6:
                            {
                                dec = "шестнадцать";
                                break;
                            }
                        case 7:
                            {
                                dec = "семнадцать";
                                break;
                            }
                        case 8:
                            {
                                dec = "восемнадцать";
                                break;
                            }
                        case 9:
                            {
                                dec = "девятнадцать";
                                break;
                            }
                    }
                }
                else
                {
                    switch (numb % 10)
                    {
                        case 0:
                            {
                                ed = "";
                                break;
                            }
                        case 1:
                            {
                                ed = "один";
                                break;
                            }
                        case 2:
                            {
                                ed = "два";
                                break;
                            }
                        case 3:
                            {
                                ed = "три";
                                break;
                            }
                        case 4:
                            {
                                ed = "четыре";
                                break;
                            }
                        case 5:
                            {
                                ed = "пять";
                                break;
                            }
                        case 6:
                            {
                                ed = "шесть";
                                break;
                            }
                        case 7:
                            {
                                ed = "семь";
                                break;
                            }
                        case 8:
                            {
                                ed = "восемь";
                                break;
                            }
                        case 9:
                            {
                                ed = "девять";
                                break;
                            }
                    }

                }
                #endregion
                Console.WriteLine("{0} {1} {2}", sot, dec, ed);
            }
            
            Console.ReadLine();
        }
    }
}
