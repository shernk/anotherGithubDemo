using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // This is the rules cannot be SEALED class: 

    /* Declaration like the example below are wrong:
     * abstract sealed class Window{}
    */

    // Abstract method just only initiated within abstraction class.

    // An unused abstract method specifices from access as private.

    // The abstract method itself includes the concept of virtual:
    /* 
     * abstract class Window
       {
          private abstract static void DrawWindow();
       }
    */

     // If the specificed access is not the same, the compiler will report an error.
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
