using System;

namespace _2_DataFlow {
    class Program {
        static int Add(int a, int b, int c = 0, float d = 1.0f, double e = 3.0) {
            Console.WriteLine("Add int 호출");
            return a + b + c;
        }
        static void Main(string[] args) {
            Program.Add(1, 2, d: 2.0f);
            //Console.WriteLine(ret);
        }
    }
}