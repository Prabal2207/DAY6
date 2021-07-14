using System;

namespace CouponNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to coupon generation:");
            Coupon();


        }

        public static void Coupon()
        {
             Console.WriteLine("Enter Number of distint coupon number to be taken:" );
             int n= Convert.ToInt32(Console.ReadLine());

             int[] coupon = new int[n+1];

             Random random = new Random();

             int i = 0;

             while (i != n)
             {
                 int check = random.Next(1,6);
                 Console.WriteLine("c" + check);
                 Console.WriteLine("i " + i);



                     if (Array.Exists(coupon, element => element == check))
                     {
                         continue;
                     }
                     else 
                     {
                         coupon[i] = check;
                         i++;

                     }
                 
             }

             for( i=0;i<coupon.Length-1;i++)
             {
                 Console.WriteLine("distinct coupon list is:" + coupon[i]);
             }


        }
    }
}
