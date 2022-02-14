using System;

namespace UnityCSharp {
    class Program {
        static void Main(string[] args) {
            int a = 0x11;
            int b = 0b11;
            int c = 11;

            Console.WriteLine($"Hexa : {a}, Binary : {b}, Dec : {c}");

            bool isA = true;
            bool isB = false;

            Console.WriteLine($"{Convert.ToInt32(isA)},,,,,{Convert.ToInt32(isB)}");
        }
    }
}