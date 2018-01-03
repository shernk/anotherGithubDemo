using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate int Calculation(int a, int b);

    class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Sub(int a, int b)
        {
            return a - b;
        }

        static int Calculate(int a, int b, Calculation cal)
        {
            return cal(a, b);
        }
            
        static void Main(string[] args)
        {
            int c = Calculate(5, 4, Add);
            Console.WriteLine("c = {0}", c);

            int d = Calculate(5, 4, Sub);
            Console.WriteLine("d = {0}", d);
                
            Console.ReadLine();
        }
    }
}
