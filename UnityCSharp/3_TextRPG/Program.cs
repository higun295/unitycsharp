using System;

namespace _3_TextRPG {
    class Program {
        static void Print(int value) {
            Console.WriteLine(value);
        }
        static int AddAndPrint(int a, int b) {
            int ret = a + b;
            Print(ret);
            return ret;
        }
        static void Main(string[] args) {
            Program.AddAndPrint(5, 15);
            Program.AddAndPrint(5, 15);
            Program.AddAndPrint(5, 15);
            Program.AddAndPrint(5, 15);
            Program.AddAndPrint(5, 15);
            Program.AddAndPrint(10, 20);
        }
    }
}
