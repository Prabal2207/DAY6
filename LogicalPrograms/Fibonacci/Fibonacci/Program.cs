using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci Series Computation");
            Fib();
        }

        public static void Fib()
        {
            Console.WriteLine("Enter range ");
            int N = Convert.ToInt32(Console.ReadLine());

            int a = 0;
            int b = 1;
            int result=0;
            int i = 0;

            while (i < N)
            {
                result = a + b;
                b = result;
                i++;

            }
            Console.WriteLine(value: "Fibonacci : " + result);
        }
    }
}
