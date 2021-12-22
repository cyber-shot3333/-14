using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Васька");
            cat.ShowInfo();
            Console.WriteLine();
            Dog dog = new Dog("Бобик");
            dog.ShowInfo();
            Console.WriteLine();
            Console.WriteLine("Для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();
        }
    }
    abstract class Animal
    {
        public abstract string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public abstract void Say();

        public void ShowInfo()
        {
            Console.Write("{0} говорит: ", Name);
            Say();
        }
    }

    class Cat : Animal
    {
        public override string Name { get; set; }

        public Cat(string Name)
            : base(Name)
        {
            this.Name = Name;
        }

        public override void Say()
        {
            Console.WriteLine("Мяу! Покорми меня!");
        }
    }

    class Dog : Animal
    {
        public override string Name { get; set; }

        public Dog(string Name)
            : base(Name)
        {
            this.Name = Name;
        }

        public override void Say()
        {
            Console.WriteLine("Гав! Пойдем гулять!");
        }
    }
}
