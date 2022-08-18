using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату точки А");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату точки В");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату точки С");
            int C = Convert.ToInt32(Console.ReadLine());
            #region    // Проверка точек на совпадение
            if (A == B || A == C || B == C)
            {
                Console.WriteLine("Ошибка!: Точки не должны совпадать друг с другом! Повнимательнее, пожалуйста");                            
            }
            else
            {
                if (Math.Abs(A - B) == Math.Abs(A - C))
                {
                    Console.WriteLine("Ошибка!: Точки В и С находятся на одинаковом расстоянии до А");                   
                }
                
                else
                {
                    #endregion
                    if (Math.Abs(A - B) > Math.Abs(A - C))
                    {
                        Console.WriteLine("точка С расположена к А ближе, чем точка В, расстояние АС = {0}", Math.Abs(A - C));                        
                    }
                    else
                    {
                        Console.WriteLine("точка В расположена к А ближе, чем точка С, расстояние АВ = {0}", Math.Abs(A - B));                       
                    }
                }
            }
            Console.ReadKey();

        }
    }
}
