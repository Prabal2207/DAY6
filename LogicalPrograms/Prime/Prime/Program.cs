using System;

namespace Prime
{
    

        class PrimeNumber
        {
          static void Main(string[] args)
          {

            Console.Write("Enter number you want to check: ");
            int n = int.Parse(Console.ReadLine());
            //int count = 0;



            for (int i = 2; i <= n / 2; i++)
            {

                if (n % i == 0)
                {
                    Console.WriteLine(n + " is not a prime number.");
                    break;

                }
                Console.WriteLine(n + " is a prime number.");
            }

            
          }
        




        }


 }

