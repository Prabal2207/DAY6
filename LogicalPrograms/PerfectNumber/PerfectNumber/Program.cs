using System;

namespace PerfectNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Perfect Number Implementation:");
            PerfectNumber();
        }

        public static void PerfectNumber()
        {
            Console.WriteLine("Enter Number to be checked for perfect number");
            int num= Convert.ToInt32(Console.ReadLine());
            
            int sum = 0;

            for(int i=1;i<=num/2;i++)
            {
                if(num%i == 0)
                { 
                    sum += i;
                }
                
            }
            
            if (sum == num)
            {
                Console.WriteLine(num + " is perfect number.");
            }
            else
            {
                Console.WriteLine(num +" is not a perfect number.");
            }

            
        }
    }
}
