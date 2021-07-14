using System;

namespace dayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter day:");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter month:");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter year30:");
            int year = Convert.ToInt32(Console.ReadLine());
            dayOfWeek(day,month,year);
        }
        public static void dayOfWeek(int day,int month,int year)
        {
            int y1,m1,d1;
            int x;
            y1 = year - (14 - month) / 12;
            x = y1 + y1 / 4 - y1 / 100 + y1 / 400;
            m1 = month + 12 * ((14 - month) / 12) - 2;
            d1 = (day + x + 31 * m1 / 12) % 7;

            Console.WriteLine("Day is:" + d1);
        }
    }
}
