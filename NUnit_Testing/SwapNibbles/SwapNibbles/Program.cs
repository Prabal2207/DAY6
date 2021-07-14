using System;
using System.Collections.Generic;
using System.Linq;

namespace SwapNibbles
{
    class Program
    {
        public static void Main()
        {

            Console.WriteLine("Enter number to convert in Binary :");
            int number = Convert.ToInt32(Console.ReadLine());
            ToBinary(number);
        }

        public static void ToBinary(int number)
        {

            

            List<int> binary = new List<int>();
            int i = 0;

            while (number > 0)
            {
                binary.Insert(i,number % 2);
                number = number / 2;
                i++;
            }
            int y = 0;
            List<int> arr = new List<int>();
            for (int j = i-1 ; j >= 0; j--)
            {
                arr.Insert(y++,binary[j]);
                Console.WriteLine("Binary is:" + binary[j]);
            }

            if(arr.Count != 8)
            {
                arr.Insert(0, 0);
            }

            List<int> Nibble_One = new List<int>();
            List<int> Nibble_Two = new List<int>();
            List<int> Final = new List<int>();

            int l = 0;
            int a = 0;
            int b = 0;

            for (int k = 0; k < 4; k++)
            {
                Nibble_One.Insert(a++,arr[k]);
                //Console.WriteLine("nib1 ;" + Nibble_One[a]);
            }


            for (int k = 4; k < arr.Count; k++)
            {
                Nibble_Two.Insert(b++,arr[k]);
                //Console.WriteLine("NIB2 :" + Nibble_Two[k]);
            }
            

            for (int z = 0; z < Nibble_Two.Count; z++)
            {
                Final.Insert(l++ ,Nibble_Two[z]);
                //Console.WriteLine(Final[l]);
            }


            for (int z = 0; z < Nibble_One.Count; z++)
            {
                Final.Insert(l++,Nibble_One[z]);
                // Console.WriteLine(Final[l]);
            }

            for (l = 0; l < Final.Count; l++)
            {
                Console.WriteLine("SWAP:" + Final[l]);
            }

            int result = Final.Aggregate((result, x) => result * 10 + x);
            Console.WriteLine("Result :" +result);

            

            int num = result;
            int dec_value = 0;

            int base1 = 1;

            int temp = num;
            while (temp > 0)
            {
                int last_digit = temp % 10;
                temp = temp / 10;

                dec_value += last_digit * base1;

                base1 = base1 * 2;
            }

            Console.WriteLine("Converted Number is : " +dec_value);

        }
    }
}
    












        
