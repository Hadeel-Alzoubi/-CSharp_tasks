using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            Cat cat = new Cat("cat");
            cat.MakeSound();
            cat.Sleep();
            cat.Eat();

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("-------------------------------------");

            Dog dog = new Dog("dog");
            dog.MakeSound();
            dog.Sleep();
            dog.Eat();
            Console.ReadKey();
        }
    }

    interface ISound
    {
        void MakeSound();
    }

    abstract class Animal
    {
        private string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }
        public abstract void Eat();

       public void Sleep()
        {
            Console.WriteLine($"{Name} is Sleeping ");
        }

    }

    class Dog : Animal, ISound
    {
        public Dog(string name) : base(name)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("The Dog Eat bone .");
        }

        public void MakeSound()
        {
            Console.WriteLine("The Dog Sound Ho Ho .");
        }
    }

    class Cat : Animal , ISound
    {
        public Cat(string name) : base(name)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("The Cat Eat meat .");
        }

        public void MakeSound()
        {
            Console.WriteLine("The Cat Sound Mew Mew .");
        }
    }
}
