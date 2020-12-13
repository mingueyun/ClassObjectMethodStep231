using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectMethodStep231
{
    class Program
    {
        static void Main(string[] args)
        {
            Classy something = new Classy();
            Console.WriteLine("Enter a number ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int b;
            something.ClassyNew(num2, out b);
            Console.WriteLine(num2 + " divided by 2 is : " + b);

            SomethingNew.something();
            Console.ReadLine();

        }
    }

    public static class SomethingNew
    {
        public static void something()
        {
            Console.WriteLine("calling a static class and method which is a string");
        }
    }
}
