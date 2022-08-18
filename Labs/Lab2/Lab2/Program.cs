using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program
    {
        // Метод находит сумму двух чисел
        static void Main(string[] args)
        {
            #region Инициализация переменных
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            #endregion
            int Sum = firstNumber + secondNumber;
            Console.WriteLine("Сумма = {0}", Sum); // 10 + 20 = 30
            Console.Write("Для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();
        }
    }
}
