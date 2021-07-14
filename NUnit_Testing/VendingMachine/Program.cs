using System;

namespace VendingMachine
{
    class Program
    {

        public static void VendingMachine(int Rupees)
        {
            int[] notes = new int[] { 1000, 500, 200, 100, 50, 20, 10, 5, 1 };
            int[] Count = new int[9];

            for (int i = 0; i < 9; i++)
            {
                if (Rupees >= notes[i])
                {
                    Count[i] = Rupees / notes[i];
                    Rupees = Rupees - Count[i] * notes[i];
                }
            }

           
            Console.WriteLine("Currency Count ->");
            for (int i = 0; i < 9; i++)
            {
                if (Count[i] != 0)
                {
                    Console.WriteLine(notes[i] + " : "
                        + Count[i]);
                }
            }
        }
        public static void Main()
        {
            Console.WriteLine("Enter amount");
            int amount = Convert.ToInt32(Console.ReadLine());
            VendingMachine(amount);
        }
    }
}
