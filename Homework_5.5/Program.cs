using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5._5
{
    internal class Program
    {
        //Строчка
        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядок N квадратной матрицы");
            int N = Convert.ToInt16(Console.ReadLine());
            int[,] array = new int[N, N];
            int Sum = 0;
            int[] sum_array = new int[(2 * N + 2)];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    array[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }
            // Создадим одномерный массив с суммами чисел в строках и в столбцах (всего 2N сумм)
            for (int x1 = 0; x1 < (2 * N);)
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        Sum += array[i, j];
                    }
                    sum_array[x1] = Sum;
                    x1++;
                    Sum = 0;
                }
            }
            // Найдем две оставшиеся суммы чисел на главных диагоналях
            int x2 = 2 * N;
            Sum = 0;
            for (int i = 0; i < N; i++)
            {
                int j = i;
                Sum += array[i, j];
            }
            sum_array[x2] = Sum;
            int x3 = 2 * N + 1;
            Sum = 0;
            for (int i = 0; i < N; i++)
            {
                int j = (N - 1 - i);
                Sum += array[i, j];
            }
            sum_array[x3] = Sum; 
            for (int x = 0; x < (2 * N + 1); x++)
            {
                if (sum_array[x] != sum_array[x + 1])
                {
                    Console.WriteLine("Матрица не является магическим квадратом");
                    break;
                }
                else
                {
                    Console.WriteLine("Матрица является магическим квадратом");
                    break;
                }
            }
            /*foreach (int r in sum_array)
            {
                Console.Write("{0} ", r);
            }*/
            Console.ReadKey();
        }
    }
}