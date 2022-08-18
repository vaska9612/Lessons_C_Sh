using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    internal class Program
    {
        static void Main(string[] args)
            //Нахождение радиуса R и площади круга S по данным длины окружности L
        {
            double L = Convert.ToDouble(Console.ReadLine());
            double R = L / Math.PI / 2;
            double S = Math.PI * Math.Pow(R, 2);
            Console.WriteLine("R = {0}, S = {1}", R, S);
            Console.ReadKey();
        }
    }
}
