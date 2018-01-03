using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class_and_interface
{
    interface ISwimable
    {
        void Swim();
    }

    abstract class Animal
    {
        protected string name;
        protected string sound;

        public Animal() { }

        public Animal(string name, string sound)
        {
            this.name = name;
            this.sound = sound;
        }

        public void MakeSound()
        {
            Console.WriteLine("My Name is " + name + " - " + sound);
        }
    }

    class Cat : Animal
    {
        public Cat(string name)
        {
            Console.WriteLine("Cat: " + name);
        }
    }

    class Dog : Animal, ISwimable
    {
        public Dog(string name)
        {
            Console.WriteLine("Dog: " + name);
        }

        void ISwimable.Swim()
        {
            Console.WriteLine("My Name is " + name + " - " + "I can swim!!!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>
            {
                new Cat("Tom"),
                new Dog("Jack")
            };

            foreach (Animal item in animals)
            {
                item.MakeSound();

                //((ISwimable)item).Swim();               
            }   
            
            Console.ReadLine();
        }
    }
}

