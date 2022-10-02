using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Dog dog = new Dog();
            cat.Say();
            dog.Say();
            cat.ShowInfo();
            dog.ShowInfo();
            Console.ReadKey();
        }
    }
    abstract class Animal
    {
        public abstract string Name { get; set; }
        public Animal()
        {
            Name = "животное";
        }

        public abstract void Say();
        public void ShowInfo() // надо вспомнить чем void отличается от типа переменной
        {
            Console.WriteLine(Name);
            Say();
        }
    }
    class Cat:Animal
    {
        public override string Name { get; set; }
        public Cat() : base() // словом base мы отправляем значение параметра name в абстрактный класс?
        {
            Name = "кошка";
        }
        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
    }
    class Dog : Animal
    {
        public override string Name { get; set; }
        public Dog() : base()
        {
            Name = "собака";
        }
        public override void Say()
        {
            Console.WriteLine("Гав");
        }
    }
}
