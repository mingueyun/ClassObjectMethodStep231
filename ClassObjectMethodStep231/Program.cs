using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectMethodStep231
{
    static class Program
    {
        static void Main()
        {
            Classy ClueLess = new Classy();
            int a;
            ClueLess.ClassyNew(out a);


            int b, c;
            ClueLess.ClassyNew(out b, out c );
            Console.WriteLine("the value of input is {0}\n", b);
            Console.WriteLine("the value of input is {0}\n", c);
            Console.ReadLine();
        }
 
        
    }
}
