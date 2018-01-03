using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    //// Any class or struct that implements an interface implements all member and defines the full members of that interface.
    //// The member of interface cannot define, its just only declaration.
    //// Interface have not constructor.

    interface IPath
    {
        void SetSize();
    }
    interface IBorder
    {
        void SetSize();
    }
    class CCricle: IPath, IBorder
    {
        private int m_size;

        void IPath.SetSize()
        {
            m_size = 3;
            Console.WriteLine("path: {0}", m_size);
        }

        void IBorder.SetSize()
        {
            m_size = 6;
            Console.WriteLine("border: {0}", m_size);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Cannot access explicit interface members from specifice class:
            //CCricle cricle = new CCricle();
            //CCricle.setSize();
                       
            IPath path = new CCricle();
            IBorder border = new CCricle();
            
            path.SetSize();
            border.SetSize();
            
            Console.ReadKey();
        }
    }
}
