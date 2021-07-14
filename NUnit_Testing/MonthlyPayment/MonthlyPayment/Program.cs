using System;

namespace MonthlyPayment
{
    class monthlyPayment
    {
        public static void Main()
        {
            monthlyPayments();
        }
        public static void monthlyPayments()
        {
            Console.Write("Enter years : ");

                int Y = int.Parse(Console.ReadLine());
            Console.Write("Enter principal loan amount: ");
            double P = double.Parse(Console.ReadLine());
            Console.Write("Enter percent interest compounded monthly: ");
            double R = double.Parse(Console.ReadLine());

            double n = 12 * Y;
            double r = R / (12 * 100);

            double payment = (P * r) / (1 - Math.Pow((1 + r), (-n)));

            Console.WriteLine("Your Payment is: " + payment);
        }
    }
}
