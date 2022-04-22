using System;

namespace _2_DataFlow
{
    class Program
    {
        static int Add(int a, int b, int c = 0, float d = 1.0f, double e = 3.0)
        {
            Console.WriteLine("Add int 호출");
            return a + b + c;
        }
        static void Main(string[] args)
        {
            //Program.Add(1, 2, d: 2.0f);
            //Console.WriteLine(ret);

            //int a = 0;

            //// 두 가지 기능은 같은데 return을 받는 것이 좀 낫겠다.
            //Program.AddOne(ref a);
            //Console.WriteLine(a);

            //a = Program.AddOne2(a);
            //Console.WriteLine(a);

            int num1 = 10;
            int num2 = 3;

            int result1;
            int result2;
            Divide(num1, num2, out result1, out result2);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }

        static void Divide(int a, int b, out int result1, out int result2)
        {
            result1 = a / b;
            result2 = a % b;
        }

        static void AddOne(ref int number)
        {
            number = number + 1;
        }

        static int AddOne2(int number)
        {
            return number + 1;
        }
    }
}