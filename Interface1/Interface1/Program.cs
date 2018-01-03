using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    // Interface have modifier is public or internal, identify is internal.
    // Interface cannot indentify Fields.
    // The interface's method is abstract and public, and not contain body's method.
    // Declare method not must allowed write public or abstract.
    // Interface haven't Constructor.

    // Default modifier is 'internal'
    interface NoAccessModifierInterface { }

    public interface CanMove
    {
        // Methods in the Interface are public and acstract.
        // But you aren't allowed to write public or abstract here.
        void Run();
        void Back();
        int GetVelocity();
    }

    // Interface identified ST have drink ability.
    public interface CanDrink
    {
        void Drink();
    }

    public interface CanEat
    {
        void Eat();
    }

    // Nó mở rộng từ class Object (Mặc dù không ghi rõ)[Éo hiểu].
    // Interface CanMove có 3 method trìu tượng.
    // Class này mới triển khai 1 method.
    // Vì vậy nó bắt buộc phải khai báo abstract.
    // Các method còn lại phải được khai báo lại với 'public abstract'.
    public abstract class Animal : CanMove
    {
        // Nếu bạn không triển khai một phương thức nào đó của Interface
        // bạn phải viết lại nó dưới dạng một phương thức trìu tượng.
        // (Luôn luôn là public abstract)
        public abstract void Back();
        public abstract int GetVelocity();

        // Triển khai method Run() từ interface CanMove.
        // Bạn phải viết nội dung của phương thức.
        // Modifier phải là public.
        public void Run()
        {
            Console.WriteLine("Animal run...");
        }
    }

    // Class Cat mở rộng từ class Animal và thi hành 2 interface CanEat, CanDrink.
    public class Cat : Animal, CanEat, CanDrink
    {
        private String Name;
        public Cat(String name)
        {
            this.Name = name;
        }
        public String getName()
        {
            return this.Name;
        }

        // Deployment abstract method of Animal class.
        public override void Back()
        {
            Console.WriteLine(Name + " cat back ...");
        }
        public override int GetVelocity()
        {
            return 19;
        }

        // Deployment interface method.
        public void Eat()
        {

        }
        public void Drink()
        {

        }
    }

    public class Mouse : Animal, CanEat, CanDrink
    {
        public override void Back()
        {
            Console.WriteLine("Mouse back ...");
        }

        public override int GetVelocity()
        {
            return 166;
        }

        // Interface methods.
        public void Drink()
        {
            Console.WriteLine("Mouse drink ...");
        }
        public void Eat()
        {
            Console.WriteLine("Mouse eat ...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo một đối tượng CanEat
            // Một đối tượng khai báo là CanEat
            // Nhưng thực tế là Cat.
            CanEat canEat1 = new Cat("Tom");

            CanEat canEat2 = new Mouse();

            // Tính đa hình thể hiện rõ tại đây.
            // CSharp luôn biết một đối tượng là kiểu gì.
            canEat1.Eat();
            canEat2.Eat();

            bool isCat1 = canEat1 is Cat;
            Console.WriteLine("canEat1 is Cat? " + isCat1);

            bool isCat2 = canEat2 is Cat;
            Console.WriteLine("canEat2 is Cat? " + isCat2);
            if (!isCat2)
            {
                Mouse mouse = (Mouse)canEat2;
                mouse.Drink();
            }

            Console.ReadLine();
        }
    }
}
