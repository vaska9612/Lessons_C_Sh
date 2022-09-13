using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10
{
    internal class Program
    {
        // Угол задан с помощью целочисленных значений gradus - градусов, min - угловых минут, sec - угловых секунд
        // Реализовать класс, в котором указанные значения представлены в виде свойств 
        // Для свойств предусмотреть проверку корректности данных
        // Класс должен содержать конструктор для установки начальных значений, а также метод ToRadians для перевода угла в радианы
        // Создать объект на основе разработанного класса. Осуществить использование объекта в программе
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число градусов < 180");
            int gradus = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите целое число угловых минут < 60");
            int min = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите целое число угловых секунд < 60");
            int sec = Convert.ToInt16(Console.ReadLine());
            Angle angle = new Angle(gradus, min, sec);
            Console.WriteLine(angle.Gradus);
            gradus = 36;
            angle.ToChangeGradus(gradus);
            Console.WriteLine(angle.Gradus);
            Console.ReadKey();
            //int n = angle.ToRadians(gradus, min, sec);
        }
    }
    /*class Angle
    {
        public int Gradus
        {
            get
            {
                return (Gradus);
            }
            set
            {
                if (value > 0 && value < 180)
                {
                    Gradus = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Ожидается целое число градусов, < 180");
                }
            }
        }
        public int Min
        {
            get
            {
                return (Min);
            }
            set
            {
                if (value > 0 && value < 60)
                {
                    Min = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Ожидается целое число угловых минут, < 60");
                }
            }
        }
        public int Sec
        {
            get
            {
                return (Sec);
            }
            set
            {
                if (value > 0 && value <= 180)
                {
                    Sec = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Ожидается целое фисло угловых секунд, < 60");
                }
            }
        }
        public Angle(int gradus, int min, int sec)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
        }
        public void ToRadians(int gradus, int min, int sec)
        {
           radians = (gradus + min / 60 + sec / 3600) / 180 * Math.PI;
           Console.WriteLine(radians);
        }
    }*/

    class Angle
    {
        private int gradus;
        private int sec;
        private int min;

        public int Gradus
        {            
            set
            {
                if (value > 0 && value < 180)
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Ожидается целое число градусов, < 180");
                }
            }
            get
            {
                return (gradus);
            }
        }
        public int Min
        {           
            set
            {
                if (value > 0 && value < 60)
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Ожидается целое число угловых минут, < 60");
                }
            }
            get
            {
                return (min);
            }
        }
        public int Sec
        {            
            set
            {
                if (value > 0 && value <= 180)
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Ожидается целое фисло угловых секунд, < 60");
                }
            }
            get
            {
                return (sec);
            }
        }
        public Angle(int gradus, int min, int sec)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
        }
       /* public void ToRadians(int gradus, int min, int sec)
        {
            radians = (gradus + min / 60 + sec / 3600) / 180 * Math.PI;
            Console.WriteLine(radians);
        }*/

        public void ToChangeGradus(int gradus)
        {
            Gradus = gradus;
        }
    }

}