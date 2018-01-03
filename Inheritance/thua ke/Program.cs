using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thua_ke
{
    class Animal
    {
        public Animal() {}

        public void Move()
        {
            Console.WriteLine("Move ...!");
        }

    }

    class Cat : Animal
    {

        public void Say()
        {
            Console.WriteLine("Meo");
        }

        public void Catch()
        {
            Console.WriteLine("Catch Mouse");
        }
    }

    class Ant : Animal
    {}

    class Program
    {
        static void Main(string[] args)
        {
            Cat tom = new Cat();

            bool isAnimal = tom is Animal;
            Console.WriteLine("Tom is Animal?" + isAnimal);

            tom.Catch();
            tom.Say();

            Console.WriteLine("---------------");
            Animal tom2 = new Cat();
            tom2.Move();

            Console.WriteLine("---------------");
            Ant ant = new Ant();
            ant.Move();

            Console.ReadLine();
        }
    }
}
