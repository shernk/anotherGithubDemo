using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        interface IP
        {
            int Set(int id);
            void Get();
        }

        interface IAddress
        {
            string Set(string add);
            void Get();
        }

        class C : IP, IAddress
        {
            private int id;
            private string add;

            // [protected] C(){}
            public C() { }

            public int Set(int m_id)
            {
                return id = m_id * 9;
            }
            public void Get()
            {
                Console.WriteLine("ID: " + id);
            }            

            string IAddress.Set(string m_add)
            {
                return add = m_add;
            }

            void IAddress.Get()
            {
                Console.WriteLine("Address: " + add);
            }
        }

        static void Main(string[] args)
        {
            C c = new C();
            c.Set(3);
            c.Get();

            IAddress i = new C();
            i.Set("K");
            i.Get();
            
            Console.ReadLine();
        }
    }
}
