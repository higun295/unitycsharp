using System;

namespace UnityCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            int id = 123;
            int key = 401;

            int a = id ^ key;
            int b = a ^ key;

            Console.WriteLine(a);
            Console.WriteLine(b);

            //// << >> &(and) |(or) ^(xor) ~(not)
            //num = num >> 1;

            //Console.WriteLine(num);
        }
    }
}