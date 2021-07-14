using System;

namespace toBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Implementation");
            ToBinary();
        }

        public static void ToBinary()
        {

            Console.WriteLine("Enter number to convert in Binary :");
            int number= Convert.ToInt32(Console.ReadLine());

            int[] binary = new int[100];
            int i = 0;

            while(number>0)
            {
                binary[i] = number % 2;
                number = number / 2;
                i++;
            }
            int j = 0;
            for( j=i-1;j>=0;j--)
            {
                Console.WriteLine("Binary is:" + binary[j]);
            }

           

        }
    }
}
