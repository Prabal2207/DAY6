using System;

namespace Squareroot
{
    class Squareroot
    {
        public static void Main()
        {
            sqrt();
        }

        public static void sqrt()
        {
            Console.Write("Enter number: ");
            double c = double.Parse(Console.ReadLine());

            double t = c;

            double epsilon = 1e-15;


            while (Math.Abs(t - c / t) > epsilon * t)
            {
                t = ((c / t) + t) / 2;

            }

            Console.WriteLine("Square Root of {0} is {1}", c, t);
        }


    }
}
