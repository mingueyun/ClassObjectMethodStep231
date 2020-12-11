using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectMethodStep231
{
    public class Classy
    {
        public void ClassyNew(out int num1)
        {
            Console.WriteLine("Enter a number ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + " divided by 2 is : " + num1 / 2);
        }
        public void  ClassyNew(out int P, out int B)
        {
            P = 10;
            B = 12;

        }

    }
}
