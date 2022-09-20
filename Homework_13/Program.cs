using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MuiltBuilding mult_building = new MuiltBuilding("СПб", 12, 65, 45, 500);
            mult_building.Print();
            Console.ReadKey();
        }
    }
    class Building
    {
        public string Adress { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int Hight { get; set; }
        public Building(string adress, int length, int width, int hight)
        {
            Adress = adress;
            Length = length;
            Width = width;
            Hight = hight;
        }
        public void Print()
        {
            Console.WriteLine("Здание находится по адресу {0} /n Здание длиной {1}м, шириной {2}м и высотой {3}м", Adress, Length, Width, Hight);
        }
    }
    sealed class MuiltBuilding : Building
    {
        public int Floors { get; set; }
        public MuiltBuilding(string adress, int length, int width, int hight, int floors)
            : base(adress, length, width, hight)
        {
            Floors = floors;
        }
        public void Print()
        {
            base.Print();
            Console.WriteLine("Этажность: {0}", Floors);
        }
    }
}
