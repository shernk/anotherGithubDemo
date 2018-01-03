using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        interface IAnimal
        {
            void SayHello();
        }

        class Cat: IAnimal
        {
            //Cat() { } -- Erorr.

            /*public[Erorr]*/  void IAnimal.SayHello()
            {
                Console.WriteLine("Cat say!");
            }
        }

        class Dog : IAnimal
        {
            public Dog() { } 

            void IAnimal.SayHello()
            {
                Console.WriteLine("Dog say!");
            }
        }

        class Zoo
        {
            Zoo() { }

        }
       
        static void Main(string[] args)
        {
            IAnimal c = new Cat();
            c.SayHello();

            // Erorr
            //Dog d = new Dog();
            //d.SayHello();
            IAnimal d = new Dog();
            d.SayHello();

            Console.ReadLine();
        }
    }
}
